using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Telco;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ReadNCPDP
{
    class ReadNCPDPFileWithInheritedTemplate
    {
        /// <summary>
        /// Reads NCPDP file into a custom, partner-specific template.
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

            var claims = ncpdpItems.OfType<TSB1Custom>();
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("HL7", "TSB1")]
    public class TSB1Custom : TSB1
    {
        //  Change the AM07 to be optional instead of mandatory
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public new List<Loop_AM07_TSB1> AM07Loop { get; set; }
    }
}
