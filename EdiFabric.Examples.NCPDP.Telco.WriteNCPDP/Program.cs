namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            //  Write EDI to stream and then to string or file
            WriteHL7ToStream.Run();
            WriteHL7ToStreamAsync.Run();

            //  Write EDI directly to file
            WriteHL7ToFile.Run();

            //  Write batches
            WriteHL7Batch.Run1();
            WriteHL7Batch.Run2();
        }
    }
}
