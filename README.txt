Thank you for downloading EdiFabric's NCPDP Telecommunications examples

1. Overview
The examples are organized into different projects in two logical categories: by product feature and by message type. All examples are provided for both .NET Framework 4.8 and .NET 6 in separate Visual Studio solutions.

2. Requirements
- Visual Studio, compatible with the supported .NET versions
- Minimum .NET Framework 4.8 or .NET 6. Downgrade to .NET Framework 4.5 is possible by changing the target framework for each project.

3. Serial Key and EdiFabric DLLs
All projects reference EdiFabric EDI Tools as NuGet packages from nuget.org. If you wish to install EdiFabric EDI Tools as DLLs, download the trial DLLs from https://sowl.co/oApEt. 

4. Setup
Rebuild the solution with Package Restore enabled. If there are any build errors, manually install the missing packages from https://www.nuget.org/packages?q=edifabric.

5. Getting started
To get started, set project EdiFabric.Examples.NCPDP.Telco.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own NCPDP files.

6. Examples by feature
Explore the different features of EdiFabric, such as translating from NCPDP file (ReadNCPDP), generating NCPDP file (WriteNCPDP), validating NCPDP transactions (ValidateNCPDP), 
import/export from/to JSON , XML, CSV.

7. Validation
All templates in EdiFabric.Templates.Ncpdp can be used for validation. 

8. EDI Templates
The trial comes with the following prebuilt template assemblies:

EdiFabric.Templates.Ncpdp.dll - NCPDP Telecommunications D.0

EdiFabric supports all NCPDP versions and message types. We have an extensive library of EDI templates, however, if you can't find a particular transaction, please let us know. 
The following templates are available out-of-the-box:

https://support.edifabric.com/hc/en-us/articles/360017128517-NCPDP-Telecommunications-Version-D-0

For an interactive view of all templates go to EdiNation (no registration is required):
https://edination.com/edi-formats.html

9. Trial use
The trial serial key is valid for 14 days, and using the product with a trial license is subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the product will begin throwing exceptions. 
To continue using the trial and the examples, you'll need to request a trial extension.

10. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.

11. Additional information

Install EdiFabric
https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric

Trial and examples
https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples

EdiFabric tutorial
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base
https://support.edifabric.com

Support
https://support.edifabric.com/hc/en-us/requests/new

Last updated on June 20, 2023
2023 � EdiFabric