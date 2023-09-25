using EdiFabric.Examples.NCPDP.Telco.Common;
using System;

namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Write EDI to stream and then to string or file
            WriteNCPDPToStream.Run();
            WriteNCPDPToStreamAsync.Run();

            //  Write EDI directly to file
            WriteNCPDPToFile.Run();

            //  Write batches
            WriteNCPDPBatch.Run1();
            WriteNCPDPBatch.Run2();
        }
    }
}
