using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Telco;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Examples.NCPDP.Telco.ValidateNCPDP
{
    class ValidateTransmissionHeader
    {
        /// <summary>
        /// Validate the typed control segments
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\ClaimBillings");

            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                while (ncpdpReader.Read())
                {
                    var header = ncpdpReader.Item as TransmissionHeader;
                    if (header != null)
                    {
                        //  Validate 
                        var headerErrors = header.Validate();
                        //  Pull the sending application from TransmissionHeader
                        var senderId = header.SenderId_2;
                        Debug.WriteLine("Sending application:");
                        Debug.WriteLine(senderId);
                    }
                }
            }
        }
    }
}
