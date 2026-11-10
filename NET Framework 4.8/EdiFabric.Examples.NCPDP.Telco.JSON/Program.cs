using EdiFabric.Examples.NCPDP.Telco.Common;
using System;

namespace EdiFabric.Examples.NCPDP.Telco.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            License.EnsureToken(Config.TrialSerialKey, 3600);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
