using EdiFabric.Examples.NCPDP.Telco.Common;

namespace EdiFabric.Examples.NCPDP.Telco.ValidateNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

            //  Validate custom NCPDP codes
            ValidateCustomNCPDPCodes.Run();
            ValidateCustomNCPDPCodes.Run2();

            //  Validate transactions 
            ValidateNCPDPTransations.Run();

            //  Validate transactions with custom code
            ValidateNCPDPTransationsWithCustomCode.Run();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Default();

            //  Validate control segment TransmissionHeader
            ValidateTransmissionHeader.Run();

            //  Validate async
            ValidateNCPDPTransationsAsync.Run();
        }
    }
}
