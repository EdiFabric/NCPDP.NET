namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class Config
    {
        public static string TrialSerialKey = "c417cb9dd9d54297a55c032a74c87996";
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
#endif

    }
}
