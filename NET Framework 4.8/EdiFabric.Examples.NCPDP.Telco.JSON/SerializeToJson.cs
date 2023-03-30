using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.JSON
{
    class SerializeToJson
    {
        /// <summary>
        /// Serialize an NCPDP object to Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();
            }

            var transactions = ncpdpItems.OfType<TSB1>();
            foreach (var transaction in transactions)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(transaction);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}
