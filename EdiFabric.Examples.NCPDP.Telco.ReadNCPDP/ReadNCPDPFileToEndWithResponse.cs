using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Telco;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.TelcoD0;

namespace EdiFabric.Examples.NCPDP.Telco.ReadNCPDP
{
    class ReadNCPDPFileToEndWithResponse
    {
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\ClaimBillingAndResponse");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpTelcoReader(ncpdpStream, TypeFactory))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var claims = ncpdpItems.OfType<TSB1>();
            var rsponses = ncpdpItems.OfType<TSRESPONSE>();
        }

        static TypeInfo TypeFactory(TransmissionHeader transmissionHeader, TransactionHeader transactionHeader, ResponseHeader responseHeader)
        {
            if (responseHeader != null && responseHeader.VersionReleaseNumber_2 == "D0")
                return typeof(TSRESPONSE).GetTypeInfo();
            
            if (transactionHeader != null && transactionHeader.TransactionCode_4 == "B1" && transactionHeader.VersionReleaseNumber_3 == "D0")
                return typeof(TSB1).GetTypeInfo();

            throw new Exception("Message is not supported.");
        }
    }
}
