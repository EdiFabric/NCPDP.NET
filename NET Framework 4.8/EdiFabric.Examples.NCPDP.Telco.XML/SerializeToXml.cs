using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.XML
{
    class SerializeToXml
    {
        /// <summary>
        /// Serialize an NCPDP object to XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();
            }

            var transactions = ncpdpItems.OfType<TSB1>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.Serialize();
                Debug.WriteLine(xml.Root.ToString());
            }
        }

        /// <summary>
        /// Serialize an NCPDP object to NCPDP using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();
            }

            var transactions = ncpdpItems.OfType<TSB1>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.SerializeDataContract();
                Debug.WriteLine(xml.Root.ToString());
            }
        }
    }
}
