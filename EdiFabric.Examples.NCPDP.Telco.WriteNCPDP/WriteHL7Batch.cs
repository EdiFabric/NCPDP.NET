using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class WriteHL7Batch
    {
        /// <summary>
        /// Batch multiple messages in the same transmission.
        /// </summary>
        public static void Run1()
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
                    
                    //  Write the claim 1
                    writer.Write(SegmentBuilders.BuildClaim("1"));

                    //  Write the claim 2
                    writer.Write(SegmentBuilders.BuildClaim("2"));

                    //...
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple transmissions in the same stream.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpTelcoWriter(stream))
                {
                    //  Write transmission header 1
                    writer.Write(SegmentBuilders.BuildTransmissionHeader("1"));

                    //  Write the claim 
                    writer.Write(SegmentBuilders.BuildClaim("1"));

                    //  Write transmission header 2
                    writer.Write(SegmentBuilders.BuildTransmissionHeader("1"));

                    //  Write the claim
                    writer.Write(SegmentBuilders.BuildClaim("2"));

                    //...
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
