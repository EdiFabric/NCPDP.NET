using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Telco;
using EdiFabric.Examples.NCPDP.Telco.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ReadNCPDP
{
    class ReadNCPDPFileWithTemplateResolution
    {
        /// <summary>
        /// Reads the NCPDP stream from start to end using assembly factory. Allows you to dynamically specify a separate assembly to be used for parsing.
        /// </summary>
        public static void RunWithAssemblyFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBillings");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, AssemblyFactory))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();
        }

        public static Assembly AssemblyFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "D0")
                return Assembly.Load("EdiFabric.Templates.Ncpdp");

            throw new Exception(string.Format("Version {0} is not supported.", messageContext.Version));
        }

        /// <summary>
        /// Reads the NCPDP stream from start to end using type factory. Allows you to dynamically specify the exact template to be used for parsing.
        /// </summary>
        public static void RunWithTypeFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\ClaimBillings");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, TypeFactory))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();
        }

        public static TypeInfo TypeFactory(TransmissionHeader transmissionHeader, TransactionHeader transactionHeader, ResponseHeader responseHeader)
        {
            if (transactionHeader != null && transactionHeader.TransactionCode_4 == "B1" && transactionHeader.VersionReleaseNumber_3 == "D0")
                return typeof(TSB1).GetTypeInfo();

            throw new Exception("Message is not supported.");
        }
    }
}
