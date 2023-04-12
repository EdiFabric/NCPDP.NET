using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Telco;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ValidateNCPDP
{
    class ValidateNCPDPTransationsWithCustomCode
    {
        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, (TransmissionHeader transmissionHeader, TransactionHeader transactionHeader, ResponseHeader responseHeader) => typeof(TSB1Custom).GetTypeInfo()))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claim = ncpdpItems.OfType<TSB1Custom>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!claim.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Message == "AM02 segment is missing.");
                Debug.WriteLine(customValidation.Message);
            }
        }
    }

    /// <summary>
    /// New validation attribute to apply to AM07 loops
    /// Validates that if AM03 segment exists, then AM02 segment must also exists, otherwise throws an exception
    /// Preserves the position of the missing segment within the loop, to allow the correct index to be applied in the acknowledgment
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class AM07LoopValidationAttribute : ValidationAttribute
    {
        public AM07LoopValidationAttribute() : base(10, ValidationLevel.InterSegment_SNIP4)
        {
        }

        public override SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            var position = validationContext.SegmentIndex + 1;

            var am07Loops = validationContext.InstanceContext.Instance as IList<Loop_AM07_TSB1>;
            if (am07Loops != null)
            {
                foreach (var am07Loop in am07Loops)
                {
                    //  Check if AM03 exists and AM02 also exist
                    if (am07Loop.AM03 != null && am07Loop.AM02 == null)
                        return new SegmentErrorContext("AM02", validationContext.SegmentIndex + 1, null, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                            "AM02 segment is missing.");

                    return null;
                }
            }

            return null;
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("HL7", "TSB1")]
    public class TSB1Custom : TSB1
    {
        //  Change the AM07 to be optional instead of mandatory
        [AM07LoopValidation]
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public new List<Loop_AM07_TSB1> AM07Loop { get; set; }
    }
}
