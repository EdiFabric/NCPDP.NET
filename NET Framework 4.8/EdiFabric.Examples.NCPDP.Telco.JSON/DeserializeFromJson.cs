using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Templates.TelcoD0;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text.Json;

namespace EdiFabric.Examples.NCPDP.Telco.JSON
{
    class DeserializeFromJson
    {
        /// <summary>
        /// De-serialize to an NCPDP object from Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling.json");
            var transaction = JsonSerializer.Deserialize<TSB1>(ncpdpStream.LoadToString());
        }
    }
}
