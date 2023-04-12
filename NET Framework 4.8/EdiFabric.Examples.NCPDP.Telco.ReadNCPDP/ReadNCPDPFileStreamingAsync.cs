using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Telco;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ReadNCPDP
{
    class ReadNCPDPFileStreamingAsync
    {
        /// <summary>
        /// Reads billing claims batched up in the same transmission.
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBillings");

            //  2.  Read multiple messages batched up in the same transmission
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                while (await ncpdpReader.ReadAsync())
                {
                    //  Process dispenses if no parsing errors
                    var claim = ncpdpReader.Item as TSB1;
                    if (claim != null && !claim.HasErrors)
                        ProcessClaim(ncpdpReader.CurrentTransmissionHeader, claim);
                }
            }
        }

        private static void ProcessClaim(TransmissionHeader header, TSB1 claim)
        {
            //  Do something with the claim
        }
    }
}
