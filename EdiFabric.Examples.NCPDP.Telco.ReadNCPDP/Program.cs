namespace EdiFabric.Examples.NCPDP.Telco.ReadNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            //  Read NCPDP file to the end
            ReadNCPDPFileToEnd.Run();
            ReadNCPDPFileToEndAsync.Run();

            //  Read one item at a time
            ReadNCPDPFileStreaming.Run();
            ReadNCPDPFileStreamingAsync.Run();

            //  Read using partner-specific template (inherited)
            ReadNCPDPFileWithInheritedTemplate.Run();

            //  Read using dynamic template resolution
            ReadNCPDPFileWithTemplateResolution.RunWithAssemblyFactory();
            ReadNCPDPFileWithTemplateResolution.RunWithTypeFactory();

            //  Read NCPDP file with currupt transmission header
            ReadNCPDPFileCorrupt.Run();

            //  Read NCPDP file with currupt G1
            ReadNCPDPFileCorrupt.Run2();

            //  Split transactions to repeating loops
            ReadNCPDPFileSplitting.Run();

            //  Read NCPDP file with batches of B1 and RESPONSE
            ReadNCPDPFileToEndWithResponse.Run();
        }
    }
}
