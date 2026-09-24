namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class Config
    {
        public static string TrialSerialKey = "bd96a836feca45cb91c86ee65d281f52";
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
#endif

    }
}
