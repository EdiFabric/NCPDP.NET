using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class WriteHL7ToStream
    {
        /// <summary>
        /// Generate and write NCPDP document to a stream
        /// </summary>
        public static void Run()
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
                    writer.Write(SegmentBuilders.BuildClaim());
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
