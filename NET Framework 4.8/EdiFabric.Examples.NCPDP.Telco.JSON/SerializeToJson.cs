using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.NCPDP.Telco.Common;
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

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBilling");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Examples.NCPDP.Telco.Common"))
            {
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();
            }

            var transactions = ncpdpItems.OfType<TSB1>();
            foreach (var transaction in transactions)
            {
                var options = new JsonSerializerOptions
                {
                    //TypeInfoResolver = new DefaultJsonTypeInfoResolver
                    //{
                    //    Modifiers =
                    //    {
                    //        typeInfo =>
                    //        {
                    //            if (typeInfo.Kind != JsonTypeInfoKind.Object)
                    //                return;

                    //            foreach (var property in typeInfo.Properties)
                    //            {
                    //                if (property.Name == "Id" )
                    //                {
                    //                    property.ShouldSerialize = (obj, value) => false;
                    //                }
                    //            }
                    //        }
                    //    }
                    //},
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                var json = JsonSerializer.Serialize(transaction, options);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}
