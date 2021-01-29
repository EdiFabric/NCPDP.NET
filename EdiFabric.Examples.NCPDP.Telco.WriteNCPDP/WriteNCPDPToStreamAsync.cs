using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class WriteNCPDPToStreamAsync
    {
        /// <summary>
        /// Generate and write NCPDP document to a stream async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpTelcoWriter(stream))
                {
                    //  Write the transmission header
                    writer.Write(SegmentBuilders.BuildTransmissionHeader());
                    //  Write the claim
                    await writer.WriteAsync(SegmentBuilders.BuildClaim());
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
