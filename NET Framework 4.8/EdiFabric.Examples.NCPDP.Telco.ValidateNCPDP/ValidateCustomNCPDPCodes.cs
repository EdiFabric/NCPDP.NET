using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ValidateNCPDP
{
    class ValidateCustomNCPDPCodes
    {
        /// <summary>
        /// Validate with custom NCPDP codes, different than the standard NCPDP codes
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set NCPDP codes map where the original code type will be substituted with the partner-specific code type
            Dictionary<Type, Type> codeSetMap = new Dictionary<Type, Type>();
            codeSetMap.Add(typeof(TELCO_ID_C6), typeof(TELCO_ID_C6PartnerA));

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBillings");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();

            foreach (var claim in claims)
            {
                //  Validate using NCPDP codes map
                MessageErrorContext errorContext;
                if (!claim.IsValid(out errorContext, new ValidationSettings { DataElementTypeMap = codeSetMap }))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  claim is valid, handle it downstream
                }
            }
        }

        /// <summary>
        /// Validate with custom NCPDP codes, different than the standard NCPDP codes. Load the codes dynamically at runtime.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set NCPDP codes map where the original code type will be substituted with the partner-specific code type
            var codeSetMap = new Dictionary<string, List<string>>();
            codeSetMap.Add("TELCO_ID_C6", new List<string> { "0", "1", "5" });

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();

            foreach (var claim in claims)
            {
                //  Validate using NCPDP codes map
                MessageErrorContext errorContext;
                if (!claim.IsValid(out errorContext, new ValidationSettings { DataElementCodesMap = codeSetMap }))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  claim is valid, handle it downstream
                }
            }
        }
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,5,")]
    public class TELCO_ID_C6PartnerA
    {
    }
}
