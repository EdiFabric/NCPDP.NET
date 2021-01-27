using System;
using System.Collections.Generic;

namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class SegmentBuilders
    {
        /// <summary>
        /// Build FHS
        /// </summary>
        /// <returns></returns>
        //public static FHS BuildFhs(string senderId = "LAB1", string senderFacility = "LAB", string receiverId = "DEST2", string receiverFacility = "DEST", string comment = "TESTFILE", string controlNr = "123456" )
        //{
        //    var result = new FHS();

        //    result.FileSendingApplication_02 = new FileSendingApplication();
        //    result.FileSendingApplication_02.NamespaceID_01 = senderId;

        //    result.FileSendingFacility_03 = new FileSendingFacility();
        //    result.FileSendingFacility_03.NamespaceID_01 = senderFacility;

        //    result.FileReceivingApplication_04 = new FileReceivingApplication();
        //    result.FileReceivingApplication_04.NamespaceID_01 = receiverId;

        //    result.FileReceivingFacility_05 = new FileReceivingFacility();
        //    result.FileReceivingFacility_05.NamespaceID_01 = receiverFacility;

        //    result.FileCreationDateTime_06 = DateTime.Now.Date.ToString("yyyyMMdd") + DateTime.Now.TimeOfDay.ToString("hhmmss");

        //    result.FileHeaderComment_9 = comment;

        //    result.FileControlID_10 = controlNr;

        //    return result;
        //}

        /// <summary>
        /// Build BHS
        /// </summary>
        /// <returns></returns>
        //public static BHS BuildBhs(string senderId = "LAB1", string senderFacility = "LAB", string receiverId = "DEST2", string receiverFacility = "DEST", string comment = "TESTBATCH", string controlNr = "123456")
        //{
        //    var result = new BHS();

        //    result.BatchSendingApplication_02 = new BatchSendingApplication();
        //    result.BatchSendingApplication_02.NamespaceID_01 = senderId;

        //    result.BatchSendingFacility_03 = new BatchSendingFacility();
        //    result.BatchSendingFacility_03.NamespaceID_01 = senderFacility;

        //    result.BatchReceivingApplication_04 = new BatchReceivingApplication();
        //    result.BatchReceivingApplication_04.NamespaceID_01 = receiverId;

        //    result.BatchReceivingFacility_05 = new BatchReceivingFacility();
        //    result.BatchReceivingFacility_05.NamespaceID_01 = receiverFacility;

        //    result.BatchCreationDateTime_06 = DateTime.Now.Date.ToString("yyyyMMdd") + DateTime.Now.TimeOfDay.ToString("hhmmss");

        //    result.BatchComment_9 = comment;

        //    result.BatchControlID_10 = controlNr;

        //    return result;
        //}

        //public static TSRDSO13 BuildDispense(string senderId = "LAB1", string senderFacility = "LAB", string receiverId = "DEST2", string receiverFacility = "DEST", string controlNr = "123456")
        //{
        //    var result = new TSRDSO13();

        //    //  MSH segment
        //    result.MSH = new MSH();

        //    result.MSH.SendingApplication_02 = new SendingApplication();
        //    result.MSH.SendingApplication_02.NamespaceID_01 = senderId;

        //    result.MSH.SendingFacility_03 = new SendingFacility();
        //    result.MSH.SendingFacility_03.NamespaceID_01 = senderFacility;

        //    result.MSH.ReceivingApplication_04 = new ReceivingApplication();
        //    result.MSH.ReceivingApplication_04.NamespaceID_01 = receiverId;

        //    result.MSH.ReceivingFacility_05 = new ReceivingFacility();
        //    result.MSH.ReceivingFacility_05.NamespaceID_01 = receiverFacility;

        //    result.MSH.DateTimeOfMessage_06 = DateTime.Now.Date.ToString("yyyyMMdd") + DateTime.Now.TimeOfDay.ToString("hhmm");

        //    result.MSH.MessageType_08 = new MessageType();
        //    result.MSH.MessageType_08.MessageCode_01 = "RDS";
        //    result.MSH.MessageType_08.TriggerEvent_02 = "O13";
        //    result.MSH.MessageType_08.MessageStructure_03 = "RDS_O13";

        //    result.MSH.MessageControlID_9 = controlNr;

        //    result.MSH.ProcessingID_10 = new ProcessingID();
        //    result.MSH.ProcessingID_10.ProcessingID_01 = "P";

        //    result.MSH.VersionID_11 = new VersionID();
        //    result.MSH.VersionID_11.VersionID_01 = "2.6";

        //    //  PID LOOP
        //    result.LoopPID = new Loop_PID_TSRDSO13();

        //    //  BEGIN PID LOOP

        //    //  PID segment
        //    result.LoopPID.PID = new PID();
        //    //  Patient ID
        //    result.LoopPID.PID.PatientID_02 = new ExtendedCompositeIDWithCheckDigit();
        //    result.LoopPID.PID.PatientID_02.IDNumber_01 = "0008064993";
        //    result.LoopPID.PID.PatientID_02.AssigningAuthority_04 = new ExtendedAssigningAuthority();
        //    result.LoopPID.PID.PatientID_02.AssigningAuthority_04.ExtendedAssigningAuthority01 = "ENT";
        //    result.LoopPID.PID.PatientID_02.IdentifierTypeCode_05 = "PE";
        //    result.LoopPID.PID.PatientID_02.EffectiveDate_07 = "20030806";
        //    result.LoopPID.PID.PatientID_02.ExpirationDate_08 = "200507";
        //    //  Patient Identifier
        //    result.LoopPID.PID.PatientIdentifierList_03 = new List<ExtendedCompositeIDWithCheckDigit>();

        //    var patientIdentifier1 = new ExtendedCompositeIDWithCheckDigit();
        //    patientIdentifier1.IDNumber_01 = "0008064993";
        //    patientIdentifier1.AssigningAuthority_04 = new ExtendedAssigningAuthority();
        //    patientIdentifier1.AssigningAuthority_04.ExtendedAssigningAuthority01 = "PAT";
        //    patientIdentifier1.IdentifierTypeCode_05 = "MR";
        //    patientIdentifier1.AssigningFacility_06 = new AssigningFacility();
        //    patientIdentifier1.AssigningFacility_06.NamespaceID_01 = "20030806";
        //    patientIdentifier1.EffectiveDate_07 = "2005";

        //    result.LoopPID.PID.PatientIdentifierList_03.Add(patientIdentifier1);

        //    //  Patient Name
        //    result.LoopPID.PID.PatientName_05 = new List<ExtendedPersonName>();

        //    var patientName1 = new ExtendedPersonName();
        //    patientName1.FamilyName_01 = new FamilyName();
        //    patientName1.FamilyName_01.Surname_01 = "SURNAME";
        //    patientName1.Suffix_04 = "PATA";
        //    patientName1.Prefix_05 = "AN";

        //    result.LoopPID.PID.PatientName_05.Add(patientName1);

        //    //  Patient Mothers Name
        //    result.LoopPID.PID.MothersMaidenName_06 = new List<ExtendedPersonName>();
        //    var mothersMaidenName1 = new ExtendedPersonName();
        //    mothersMaidenName1.FamilyName_01 = new FamilyName();
        //    mothersMaidenName1.FamilyName_01.Surname_01 = "EVERYWOMEN";
        //    mothersMaidenName1.GivenName_02 = "EVE";
        //    mothersMaidenName1.SecondAndFurtherGivenNamesOrInitialsThereof_03 = "J";

        //    result.LoopPID.PID.MothersMaidenName_06.Add(mothersMaidenName1);

        //    //  DOB
        //    result.LoopPID.PID.DateTimeOfBirth_07 = "19471007";

        //    //  Sex
        //    result.LoopPID.PID.AdministrativeSex_08 = "F";

        //    //  Race
        //    result.LoopPID.PID.Race_10 = new List<GuarantorRace>();

        //    var race1 = new GuarantorRace();

        //    race1.GuarantorRace01 = "1016-5";

        //    result.LoopPID.PID.Race_10.Add(race1);

        //    //  Patient Address
        //    result.LoopPID.PID.PatientAddress_11 = new List<ExtendedAddress>();

        //    var patientAddress1 = new ExtendedAddress();
        //    patientAddress1.StreetAddress_01 = new StreetAddress();
        //    patientAddress1.StreetAddress_01.StreetOrMailingAddress_01 = "2222HOMESTREET";
        //    patientAddress1.City_03 = "HOUSTON";
        //    patientAddress1.StateOrProvince_04 = "TX";
        //    patientAddress1.ZipOrPostalCode_05 = "77030";
        //    patientAddress1.Country_06 = "USA";

        //    result.LoopPID.PID.PatientAddress_11.Add(patientAddress1);

        //    //  Marital Status
        //    result.LoopPID.PID.MaritalStatus_16 = new GuarantorMaritalStatusCode();
        //    result.LoopPID.PID.MaritalStatus_16.GuarantorMaritalStatusCode01 = "S";

        //    //  Patient Account Number
        //    result.LoopPID.PID.PatientAccountNumber_18 = new ExtendedCompositeIDWithCheckDigit();
        //    result.LoopPID.PID.PatientAccountNumber_18.IDNumber_01 = "6045681";
        //    result.LoopPID.PID.PatientAccountNumber_18.AssigningAuthority_04 = new ExtendedAssigningAuthority();
        //    result.LoopPID.PID.PatientAccountNumber_18.AssigningAuthority_04.ExtendedAssigningAuthority01 = "PATA";
        //    result.LoopPID.PID.PatientAccountNumber_18.IdentifierTypeCode_05 = "AN";

        //    //  END PID LOOP

        //    //  Repeating ORC LOOP
        //    result.LoopORC = new List<Loop_ORC_TSRDSO13>();

        //    //  BEGIN ORC LOOP
        //    var orcLoop = new Loop_ORC_TSRDSO13();

        //    //  ORC Segment
        //    orcLoop.ORC = new ORC();
        //    orcLoop.ORC.OrderControl_01 = "CH";
        //    orcLoop.ORC.PlacerOrderNumber_02 = new ComprehensiveLocationIdentifier();
        //    orcLoop.ORC.PlacerOrderNumber_02.EntityIdentifier_01 = "177A";
        //    orcLoop.ORC.PlacerOrderNumber_02.NamespaceID_02 = "SMS";
        //    orcLoop.ORC.OrderStatus_05 = "ER";
        //    orcLoop.ORC.ResponseFlag_06 = "N";
        //    orcLoop.ORC.QuantityTiming_07 = new List<Timingquantity>();
        //    //  Quantity Timing
        //    var quantityTiming1 = new Timingquantity();
        //    //  Quantity
        //    quantityTiming1.Quantity_01 = new Quantity();
        //    quantityTiming1.Quantity_01.Quantity_01 = "1";
        //    quantityTiming1.Quantity_01.Units_02 = new InternationalVersionID();
        //    quantityTiming1.Quantity_01.Units_02.Identifier_01 = "1_2_1";
        //    quantityTiming1.Quantity_01.Units_02.Text_02 = "1_2_2";
        //    quantityTiming1.Quantity_01.Units_02.NameOfCodingSystem_03 = "ATC";
        //    quantityTiming1.Quantity_01.Units_02.AlternateIdentifier_04 = "1_2_4";
        //    quantityTiming1.Quantity_01.Units_02.AlternateText_05 = "1_2_5";
        //    quantityTiming1.Quantity_01.Units_02.NameOfAlternate_06 = "C4";
        //    //  Interval
        //    quantityTiming1.Interval_02 = new Interval();
        //    quantityTiming1.Interval_02.RepeatPattern_01 = "C";
        //    quantityTiming1.Interval_02.ExplicitTimeInterval_02 = "2_2";
        //    //  Duration
        //    quantityTiming1.Duration_03 = "3";
        //    //  Start Date
        //    quantityTiming1.StartDateTime_04 = new ExpirationDate();
        //    quantityTiming1.StartDateTime_04.Time_01 = "20160827";
        //    quantityTiming1.StartDateTime_04.DegreeOfPrecision_02 = "4";
        //    //  End Date
        //    quantityTiming1.EndDateTime_05 = new ExpirationDate();
        //    quantityTiming1.EndDateTime_05.Time_01 = "20160927";
        //    quantityTiming1.EndDateTime_05.DegreeOfPrecision_02 = "5";
        //    //  Priority
        //    quantityTiming1.Priority_06 = "6";
        //    //  Condition
        //    quantityTiming1.Condition_07 = "7";
        //    //  Notes
        //    quantityTiming1.Text_08 = "D";
        //    //  Conjunction
        //    quantityTiming1.Conjunction_09 = "S";
        //    //  Order Sequence
        //    quantityTiming1.OrderSequencing_10 = new OrderSequencing();
        //    quantityTiming1.OrderSequencing_10.SequenceResultsFlag_01 = "C";
        //    quantityTiming1.OrderSequencing_10.PlacerOrderNumberEntityIdentifier_02 = "177C";
        //    quantityTiming1.OrderSequencing_10.PlacerOrderNumberNamespaceID_03 = "SMS";
        //    quantityTiming1.OrderSequencing_10.FillerOrderNumberEntityIdentifier_04 = "M";
        //    quantityTiming1.OrderSequencing_10.FillerOrderNumberNamespaceID_05 = "P";
        //    quantityTiming1.OrderSequencing_10.SequenceConditionValue_06 = "*ES+0M";
        //    quantityTiming1.OrderSequencing_10.MaximumNumberOfRepeats_07 = "7";
        //    quantityTiming1.OrderSequencing_10.PlacerOrderNumberUniversalID_08 = "T";
        //    quantityTiming1.OrderSequencing_10.PlacerOrderNumberUniversalIDType_09 = "DNS";
        //    quantityTiming1.OrderSequencing_10.FillerOrderNumberUniversalID_10 = "Y";
        //    quantityTiming1.OrderSequencing_10.FillerOrderNumberUniversalIDType_11 = "DNS";
        //    //  Occurrence duration
        //    quantityTiming1.OccurrenceDuration_11 = new InternationalVersionID();
        //    quantityTiming1.OccurrenceDuration_11.Identifier_01 = "C";
        //    quantityTiming1.OccurrenceDuration_11.Text_02 = "11_2";
        //    quantityTiming1.OccurrenceDuration_11.NameOfCodingSystem_03 = "CCC";
        //    quantityTiming1.OccurrenceDuration_11.AlternateIdentifier_04 = "11_4";
        //    quantityTiming1.OccurrenceDuration_11.AlternateText_05 = "11_5";
        //    quantityTiming1.OccurrenceDuration_11.NameOfAlternate_06 = "CCC";

        //    quantityTiming1.TotalOccurrences_12 = "12";

        //    orcLoop.ORC.QuantityTiming_07.Add(quantityTiming1);

        //    orcLoop.ORC.Parent_08 = new EntityIdentifierPair();
        //    orcLoop.ORC.Parent_08.PlacerAssignedIdentifier_01 = new ComprehensiveLocationIdentifier();
        //    orcLoop.ORC.Parent_08.PlacerAssignedIdentifier_01.EntityIdentifier_01 = "177";

        //    //  BEGIN RXO LOOP
        //    orcLoop.LoopRXO = new Loop_RXO_TSRDSO13();
        //    orcLoop.LoopRXO.RXO = new RXO();
        //    orcLoop.LoopRXO.RXO.RequestedGiveCode_01 = new AssigningAgencyOrDepartment();
        //    orcLoop.LoopRXO.RXO.RequestedGiveCode_01.Identifier_01 = "Requested";
        //    orcLoop.LoopRXO.RXO.RequestedGiveAmountMinimum_02 = "125";
        //    orcLoop.LoopRXO.RXO.RequestedGiveUnits_04 = new AssigningAgencyOrDepartment();
        //    orcLoop.LoopRXO.RXO.RequestedGiveUnits_04.Identifier_01 = "ML";
        //    orcLoop.LoopRXO.RXO.RequestedDosageForm_05 = new AssigningAgencyOrDepartment();
        //    orcLoop.LoopRXO.RXO.RequestedDosageForm_05.Identifier_01 = "Requested Give Per";
        //    orcLoop.LoopRXO.RXO.ProvidersPharmacyTreatmentInstructions_06 = new List<AssigningAgencyOrDepartment>();
        //    var providerInstructions1 = new AssigningAgencyOrDepartment();
        //    providerInstructions1.Identifier_01 = "H1";

        //    orcLoop.LoopRXO.RXO.ProvidersPharmacyTreatmentInstructions_06.Add(providerInstructions1);

        //    //  END RXO LOOP

        //    //  RXD Segment
        //    orcLoop.RXD = new RXD();
        //    orcLoop.RXD.DispenseSubIDCounter_01 = "4";
        //    orcLoop.RXD.DispenseGiveCode_02 = new AdministeredCode();
        //    orcLoop.RXD.DispenseGiveCode_02.AdministeredCode01 = "01";
        //    orcLoop.RXD.DateTimeDispensed_03 = "20160927";
        //    orcLoop.RXD.ActualDispenseAmount_04 = "5";
        //    orcLoop.RXD.ActualDispenseUnits_05 = new AssigningAgencyOrDepartment();
        //    orcLoop.RXD.ActualDispenseUnits_05.Identifier_01 = "D";
        //    orcLoop.RXD.PrescriptionNumber_07 = "E";

        //    //  Repeating RXR Segments
        //    orcLoop.RXR = new List<RXR>();

        //    //  RXR Segment
        //    var rxr1 = new RXR();
        //    rxr1.Route_01 = new Route();
        //    rxr1.Route_01.Route01 = "PO";

        //    orcLoop.RXR.Add(rxr1);

        //    result.LoopORC.Add(orcLoop);

        //    //  END ORC LOOP

        //    return result;
        //}
    }
}
