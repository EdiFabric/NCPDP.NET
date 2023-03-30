using System.Diagnostics;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class WriteNCPDPToFile
    {
        /// <summary>
        /// Generate and write NCPDP document to a file
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var writer = new NcpdpTelcoWriter(@"C:\Test\Output.txt", false))
            {
                //  Write the transmission header
                writer.Write(SegmentBuilders.BuildTransmissionHeader());
                //  Write the claim
                writer.Write(SegmentBuilders.BuildClaim());
            }
        }
    }
}
