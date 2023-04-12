using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.XML
{
    class DeserializeFromXml
    {
        /// <summary>
        /// De-serialize to an NCPDP object from XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TSB1>();
        }

        /// <summary>
        /// De-serialize to an NCPDP object from XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TSB1>();
        }
    }
}
