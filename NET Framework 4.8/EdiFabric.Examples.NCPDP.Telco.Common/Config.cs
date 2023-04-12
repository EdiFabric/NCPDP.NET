namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class Config
    {
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
        public static string SerialKeyPath = @"../../../../../../edifabric/serial.key";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
        public static string SerialKeyPath = @"../../../../../edifabric/serial.key";
#endif

    }
}
