using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ReadNCPDP
{
    class ReadNCPDPFileSplitting
    {
        /// <summary>
        /// Copy a message and remove unwanted parts.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\ClaimBillingMultiLoop");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();
            var splitClaims = new List<TSB1>();

            foreach (var claim in claims)
            {
                foreach (var am07Loop in claim.AM07Loop)
                {
                    var splitClaim = claim.Copy() as TSB1;
                    splitClaim.AM07Loop.RemoveAll(l => splitClaim.AM07Loop.IndexOf(l) != claim.AM07Loop.IndexOf(am07Loop));
                    splitClaims.Add(splitClaim);
                }
            }

            foreach (var claim in claims)
                Debug.WriteLine(string.Format("Original: Claim - AM07 parts {0}", claim.AM07Loop.Count()));

            foreach (var splitClaim in splitClaims)
                Debug.WriteLine(string.Format("Split: Claim - AM07 parts {0}", splitClaim.AM07Loop.Count()));
        }
    }
}
