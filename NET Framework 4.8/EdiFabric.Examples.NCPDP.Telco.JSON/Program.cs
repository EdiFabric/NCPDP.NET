using EdiFabric.Examples.NCPDP.Telco.Common;

namespace EdiFabric.Examples.NCPDP.Telco.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
