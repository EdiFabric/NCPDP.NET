using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ValidateNCPDP
{
    class ValidateNCPDPTransationsAsync
    {
        /// <summary>
        /// Validate HL7 transactions from file async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();

            foreach (var claim in claims)
            {
                //  Validate
                Tuple<bool, MessageErrorContext> result = await claim.IsValidAsync();
                if (!result.Item1)
                {
                    //  Report it back to the sender, log, etc.
                    var errors = result.Item2.Flatten();
                }
                else
                {
                    //  claim is valid, handle it downstream
                }
            }
        }
    }
}
