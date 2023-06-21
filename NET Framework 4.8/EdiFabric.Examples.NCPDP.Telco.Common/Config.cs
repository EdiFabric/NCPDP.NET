namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class Config
    {
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
#endif

    }
}
