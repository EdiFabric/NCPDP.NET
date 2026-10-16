namespace EdiFabric.Templates.TelcoD0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Telco;

    /// <summary>
    // Patient
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM01")]
    public class AM01
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Patient ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("CX", typeof(TELCO_ID_CX))]
        [Pos(1)]
        public virtual string PatientIDQualifier_CX { get; set; }
        /// <summary>
        // Patient ID
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("CY", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string PatientID_CY { get; set; }
        /// <summary>
        // Date Of Birth
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("C4", typeof(TELCO_DT))]
        [Pos(3)]
        public virtual string DateOfBirth_C4 { get; set; }
        /// <summary>
        // Patient Gender Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("C5", typeof(TELCO_ID_C5))]
        [Pos(4)]
        public virtual string PatientGenderCode_C5 { get; set; }
        /// <summary>
        // Patient First Name
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("CA", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string PatientFirstName_CA { get; set; }
        /// <summary>
        // Patient Last Name
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("CB", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string PatientLastName_CB { get; set; }
        /// <summary>
        // Patient Street Address
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("CM", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string PatientStreetAddress_CM { get; set; }
        /// <summary>
        // Patient City Address
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("CN", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string PatientCityAddress_CN { get; set; }
        /// <summary>
        // Patient State/Province Address
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("CO", typeof(TELCO_ID_CO))]
        [Pos(9)]
        public virtual string PatientStateProvinceAddress_CO { get; set; }
        /// <summary>
        // Patient Zip/Postal Zone
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("CP", typeof(TELCO_AN))]
        [Pos(10)]
        public virtual string PatientZipPostalZone_CP { get; set; }
        /// <summary>
        // Patient Phone Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("CQ", typeof(TELCO_N0))]
        [Pos(11)]
        public virtual string PatientPhoneNumber_CQ { get; set; }
        /// <summary>
        // Place of Service
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("C7", typeof(TELCO_ID_C7))]
        [Pos(12)]
        public virtual string PlaceOfService_C7 { get; set; }
        /// <summary>
        // Employer ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("CZ", typeof(TELCO_AN))]
        [Pos(13)]
        public virtual string EmployerID_CZ { get; set; }
        /// <summary>
        // Smoker/Non-Smoker Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1C", typeof(TELCO_ID_1C))]
        [Pos(14)]
        public virtual string SmokerNonSmokerCode_1C { get; set; }
        /// <summary>
        // Pregnancy Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("2C", typeof(TELCO_ID_2C))]
        [Pos(15)]
        public virtual string PregnancyIndicator_2C { get; set; }
        /// <summary>
        // Patient E-Mail Address
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("HN", typeof(TELCO_AN))]
        [Pos(16)]
        public virtual string PatientEMailAddress_HN { get; set; }
        /// <summary>
        // Patient Residence
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("4X", typeof(TELCO_ID_4X))]
        [Pos(17)]
        public virtual string PatientResidence_4X { get; set; }
    }

    /// <summary>
    // Pharmacy Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM02")]
    public class AM02
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Provider ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("EY", typeof(TELCO_ID_EY))]
        [Pos(1)]
        public virtual string ProviderIDQualifier_EY { get; set; }
        /// <summary>
        // Provider ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("E9", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string ProviderID_E9 { get; set; }
    }

    /// <summary>
    // Prescriber
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM03")]
    public class AM03
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Prescriber ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("EZ", typeof(TELCO_ID_EZ))]
        [Pos(1)]
        public virtual string PrescriberIDQualifier_EZ { get; set; }
        /// <summary>
        // Prescriber ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("DB", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string PrescriberID_DB { get; set; }
        /// <summary>
        // Prescriber Last Name
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("DR", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string PrescriberLastName_DR { get; set; }
        /// <summary>
        // Prescriber Phone Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("PM", typeof(TELCO_N0))]
        [Pos(4)]
        public virtual string PrescriberPhoneNumber_PM { get; set; }
        /// <summary>
        // Primary Care Provider ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2E", typeof(TELCO_ID_2E))]
        [Pos(5)]
        public virtual string PrimaryCareProviderIDQualifier_2E { get; set; }
        /// <summary>
        // Primary Care Provider ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("DL", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string PrimaryCareProviderID_DL { get; set; }
        /// <summary>
        // Primary Care Provider Last Name
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("4E", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string PrimaryCareProviderLastName_4E { get; set; }
        /// <summary>
        // Prescriber First Name
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("2J", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string PrescriberFirstName_2J { get; set; }
        /// <summary>
        // Prescriber Street Address
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("2K", typeof(TELCO_AN))]
        [Pos(9)]
        public virtual string PrescriberStreetAddress_2K { get; set; }
        /// <summary>
        // Prescriber City Address
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("2M", typeof(TELCO_AN))]
        [Pos(10)]
        public virtual string PrescriberCityAddress_2M { get; set; }
        /// <summary>
        // Prescriber State/Province Address
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2N", typeof(TELCO_ID_2N))]
        [Pos(11)]
        public virtual string PrescriberStateProvinceAddress_2N { get; set; }
        /// <summary>
        // Prescriber Zip/Postal Zone
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("2P", typeof(TELCO_AN))]
        [Pos(12)]
        public virtual string PrescriberZipPostalZone_2P { get; set; }
    }

    /// <summary>
    // Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM04")]
    public class AM04
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Controlled Substance Reporting Reversal Request
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 20)]
        [DataElement("C2", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string CardholderID_C2 { get; set; }
        /// <summary>
        // Cardholder First Name
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("CC", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string CardholderFirstName_CC { get; set; }
        /// <summary>
        // Cardholder Last Name
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("CD", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string CardholderLastName_CD { get; set; }
        /// <summary>
        // Home Plan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("CE", typeof(TELCO_AN))]
        [Pos(4)]
        public virtual string HomePlan_CE { get; set; }
        /// <summary>
        // Plan ID
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FO", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string PlanID_FO { get; set; }
        /// <summary>
        // Eligibility Clarification Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("C9", typeof(TELCO_ID_C9))]
        [Pos(6)]
        public virtual string EligibilityClarificationCode_C9 { get; set; }
        /// <summary>
        // Group ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("C1", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string GroupID_C1 { get; set; }
        /// <summary>
        // Person Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("C3", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string PersonCode_C3 { get; set; }
        /// <summary>
        // Patient Relationship Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("C6", typeof(TELCO_ID_C6))]
        [Pos(9)]
        public virtual string PatientRelationshipCode_C6 { get; set; }
        /// <summary>
        // Other Payer BIN Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("MG", typeof(TELCO_N0))]
        [Pos(10)]
        public virtual string OtherPayerBINNumber_MG { get; set; }
        /// <summary>
        // Other Payer Processor Control Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("MH", typeof(TELCO_AN))]
        [Pos(11)]
        public virtual string OtherPayerProcessorControlNumber_MH { get; set; }
        /// <summary>
        // Other Payer Cardholder ID
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("NU", typeof(TELCO_AN))]
        [Pos(12)]
        public virtual string OtherPayerCardholderID_NU { get; set; }
        /// <summary>
        // Other Payer Group ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("MJ", typeof(TELCO_AN))]
        [Pos(13)]
        public virtual string OtherPayerGroupID_MJ { get; set; }
        /// <summary>
        // Medigap ID
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("2A", typeof(TELCO_AN))]
        [Pos(14)]
        public virtual string MedigapID_2A { get; set; }
        /// <summary>
        // Medicaid Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2B", typeof(TELCO_ID_2B))]
        [Pos(15)]
        public virtual string MedicaidIndicator_2B { get; set; }
        /// <summary>
        // Provider Accept Assignment Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("2D", typeof(TELCO_ID_2D))]
        [Pos(16)]
        public virtual string ProviderAcceptAssignmentIndicator_2D { get; set; }
        /// <summary>
        // CMS Part D Defined Qualified Facility
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("G2", typeof(TELCO_ID_G2))]
        [Pos(17)]
        public virtual string CMSPartDDefinedQualifiedFacility_G2 { get; set; }
        /// <summary>
        // Medicaid ID Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("N5", typeof(TELCO_AN))]
        [Pos(18)]
        public virtual string MedicaidIDNumber_N5 { get; set; }
        /// <summary>
        // Medicaid Agency Number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("N6", typeof(TELCO_AN))]
        [Pos(19)]
        public virtual string MedicaidAgencyNumber_N6 { get; set; }
    }

    /// <summary>
    // Coordination of Benefits/Other Payments
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM05")]
    public class AM05
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Coordination of Benefits/Other Payments Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("4C", typeof(TELCO_N0))]
        [Pos(1)]
        public virtual string CoordinationOfBenefitsOtherPaymentsCount_4C { get; set; }
        /// <summary>
        // Coordination of Benefits/Other Payments Count
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C4C> C4C_02 { get; set; }
    }

    /// <summary>
    // Workers' Compensation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM06")]
    public class AM06
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Date Of Injury
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("DY", typeof(TELCO_DT))]
        [Pos(1)]
        public virtual string DateOfInjury_DY { get; set; }
        /// <summary>
        // Employer Name
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("CF", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string EmployerName_CF { get; set; }
        /// <summary>
        // Employer Street Address
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("CG", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string EmployerStreetAddress_CG { get; set; }
        /// <summary>
        // Employer City Address
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("CH", typeof(TELCO_AN))]
        [Pos(4)]
        public virtual string EmployerCityAddress_CH { get; set; }
        /// <summary>
        // Employer State/Province Address
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("CI", typeof(TELCO_ID_CI))]
        [Pos(5)]
        public virtual string EmployerStateProvinceAddress_CI { get; set; }
        /// <summary>
        // Employer Zip/Postal Zone
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("CJ", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string EmployerZipPostalZone_CJ { get; set; }
        /// <summary>
        // Employer Phone Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("CK", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string EmployerPhoneNumber_CK { get; set; }
        /// <summary>
        // Employer Contact Name
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("CL", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string EmployerContactName_CL { get; set; }
        /// <summary>
        // Carrier ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("CR", typeof(TELCO_AN))]
        [Pos(9)]
        public virtual string CarrierID_CR { get; set; }
        /// <summary>
        // Claim/Reference ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("DZ", typeof(TELCO_AN))]
        [Pos(10)]
        public virtual string ClaimReferenceID_DZ { get; set; }
        /// <summary>
        // Billing Entity Type Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("TR", typeof(TELCO_ID_TR))]
        [Pos(11)]
        public virtual string BillingEntityTypeIndicator_TR { get; set; }
        /// <summary>
        // Pay To Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("TS", typeof(TELCO_ID_TS))]
        [Pos(12)]
        public virtual string PayToQualifier_TS { get; set; }
        /// <summary>
        // Pay To ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("TT", typeof(TELCO_AN))]
        [Pos(13)]
        public virtual string PayToID_TT { get; set; }
        /// <summary>
        // Pay To Name
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("TU", typeof(TELCO_AN))]
        [Pos(14)]
        public virtual string PayToName_TU { get; set; }
        /// <summary>
        // Pay To Street Address
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("TV", typeof(TELCO_AN))]
        [Pos(15)]
        public virtual string PayToStreetAddress_TV { get; set; }
        /// <summary>
        // Pay To City Address
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("TW", typeof(TELCO_AN))]
        [Pos(16)]
        public virtual string PayToCityAddress_TW { get; set; }
        /// <summary>
        // Pay to State/Province Address
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("TX", typeof(TELCO_ID_TX))]
        [Pos(17)]
        public virtual string PayToStateProvinceAddress_TX { get; set; }
        /// <summary>
        // Pay To Zip/Postal Zone
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("TY", typeof(TELCO_AN))]
        [Pos(18)]
        public virtual string PayToZipPostalZone_TY { get; set; }
        /// <summary>
        // Generic Equivalent Product ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("TZ", typeof(TELCO_ID_TZ))]
        [Pos(19)]
        public virtual string GenericEquivalentProductIDQualifier_TZ { get; set; }
        /// <summary>
        // Generic Equivalent Product ID
        /// </summary>
        [DataMember]
        [StringLength(1, 19)]
        [DataElement("UA", typeof(TELCO_AN))]
        [Pos(20)]
        public virtual string GenericEquivalentProductID_UA { get; set; }
    }

    /// <summary>
    // Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM07")]
    public class AM07
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Prescription/Service Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("EM", typeof(TELCO_ID_EM))]
        [Pos(1)]
        public virtual string PrescriptionServiceReferenceNumberQualifier_EM { get; set; }
        /// <summary>
        // Prescription/Service Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("D2", typeof(TELCO_N0))]
        [Pos(2)]
        public virtual string PrescriptionServiceReferenceNumber_D2 { get; set; }
        /// <summary>
        // Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("E1", typeof(TELCO_ID_E1))]
        [Pos(3)]
        public virtual string ProductServiceIDQualifier_E1 { get; set; }
        /// <summary>
        // Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 19)]
        [DataElement("D7", typeof(TELCO_AN))]
        [Pos(4)]
        public virtual string ProductServiceID_D7 { get; set; }
        /// <summary>
        // Associated Prescription/Service Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("EN", typeof(TELCO_N0))]
        [Pos(5)]
        public virtual string AssociatedPrescriptionServiceReferenceNumber_EN { get; set; }
        /// <summary>
        // Associated Prescription/Service Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("EP", typeof(TELCO_DT))]
        [Pos(6)]
        public virtual string AssociatedPrescriptionServiceDate_EP { get; set; }
        /// <summary>
        // Procedure Modifier Code Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("SE", typeof(TELCO_N0))]
        [Pos(7)]
        public virtual string ProcedureModifierCodeCount_SE { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<CSE> CSE_08 { get; set; }
        /// <summary>
        // Quantity Dispensed
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("E7", typeof(TELCO_N3))]
        [Pos(9)]
        public virtual string QuantityDispensed_E7 { get; set; }
        /// <summary>
        // Fill Number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("D3", typeof(TELCO_ID_D3))]
        [Pos(10)]
        public virtual string FillNumber_D3 { get; set; }
        /// <summary>
        // Days Supply
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("D5", typeof(TELCO_N0))]
        [Pos(11)]
        public virtual string DaysSupply_D5 { get; set; }
        /// <summary>
        // Compound Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("D6", typeof(TELCO_ID_D6))]
        [Pos(12)]
        public virtual string CompoundCode_D6 { get; set; }
        /// <summary>
        // Dispense As Written (DAW)/Product Selection Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("D8", typeof(TELCO_ID_D8))]
        [Pos(13)]
        public virtual string DispenseAsWritten_D8 { get; set; }
        /// <summary>
        // Date Prescription Written
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("DE", typeof(TELCO_DT))]
        [Pos(14)]
        public virtual string DatePrescriptionWritten_DE { get; set; }
        /// <summary>
        // Number of Refills Authorized
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("DF", typeof(TELCO_ID_DF))]
        [Pos(15)]
        public virtual string NumberOfRefillsAuthorized_DF { get; set; }
        /// <summary>
        // Prescription Origin Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("DJ", typeof(TELCO_ID_DJ))]
        [Pos(16)]
        public virtual string PrescriptionOriginCode_DJ { get; set; }
        /// <summary>
        // Submission Clarification Code Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("NX", typeof(TELCO_N0))]
        [Pos(17)]
        public virtual string SubmissionClarificationCodeCount_NX { get; set; }
        [DataMember]
        [ListCount(3)]
        [Pos(18)]
        public virtual List<CNX> CNX_18 { get; set; }
        /// <summary>
        // Quantity Prescribed
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("ET", typeof(TELCO_N3))]
        [Pos(19)]
        public virtual string QuantityPrescribed_ET { get; set; }
        /// <summary>
        // Other Coverage Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("C8", typeof(TELCO_ID_C8))]
        [Pos(20)]
        public virtual string OtherCoverageCode_C8 { get; set; }
        /// <summary>
        // Special Packaging Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("DT", typeof(TELCO_ID_DT))]
        [Pos(21)]
        public virtual string SpecialPackagingIndicator_DT { get; set; }
        /// <summary>
        // Originally Prescribed Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("EJ", typeof(TELCO_ID_EJ))]
        [Pos(22)]
        public virtual string OriginallyPrescribedProductServiceIDQualifier_EJ { get; set; }
        /// <summary>
        // Originally Prescribed Product/Service Code
        /// </summary>
        [DataMember]
        [StringLength(1, 19)]
        [DataElement("EA", typeof(TELCO_AN))]
        [Pos(23)]
        public virtual string OriginallyPrescribedProductServiceCode_EA { get; set; }
        /// <summary>
        // Originally Prescribed Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("EB", typeof(TELCO_N3))]
        [Pos(24)]
        public virtual string OriginallyPrescribedQuantity_EB { get; set; }
        /// <summary>
        // Alternate ID
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("CW", typeof(TELCO_AN))]
        [Pos(25)]
        public virtual string AlternateID_CW { get; set; }
        /// <summary>
        // Scheduled Prescription ID Number
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("EK", typeof(TELCO_AN))]
        [Pos(26)]
        public virtual string ScheduledPrescriptionIDNumber_EK { get; set; }
        /// <summary>
        // Unit Of Measure
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("28", typeof(TELCO_ID_28))]
        [Pos(27)]
        public virtual string UnitOfMeasure_28 { get; set; }
        /// <summary>
        // Level Of Service
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("DI", typeof(TELCO_ID_DI))]
        [Pos(28)]
        public virtual string LevelOfService_DI { get; set; }
        /// <summary>
        // Prior Authorization Type Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("EU", typeof(TELCO_ID_EU))]
        [Pos(29)]
        public virtual string PriorAuthorizationTypeCode_EU { get; set; }
        /// <summary>
        // Prior Authorization Number Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("EV", typeof(TELCO_ID_EV))]
        [Pos(30)]
        public virtual string PriorAuthorizationNumberSubmitted_EV { get; set; }
        /// <summary>
        // Intermediary Authorization Type ID
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("EW", typeof(TELCO_ID_EW))]
        [Pos(31)]
        public virtual string IntermediaryAuthorizationTypeID_EW { get; set; }
        /// <summary>
        // Intermediary Authorization ID
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("EX", typeof(TELCO_AN))]
        [Pos(32)]
        public virtual string IntermediaryAuthorizationID_EX { get; set; }
        /// <summary>
        // Dispensing Status
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("HD", typeof(TELCO_ID_HD))]
        [Pos(33)]
        public virtual string DispensingStatus_HD { get; set; }
        /// <summary>
        // Quantity Intended To Be Dispensed
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("HF", typeof(TELCO_N3))]
        [Pos(34)]
        public virtual string QuantityIntendedToBeDispensed_HF { get; set; }
        /// <summary>
        // Days Supply Intended To Be Dispensed
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("HG", typeof(TELCO_N0))]
        [Pos(35)]
        public virtual string DaysSupplyIntendedToBeDispensed_HG { get; set; }
        /// <summary>
        // Delay Reason Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("NV", typeof(TELCO_ID_NV))]
        [Pos(36)]
        public virtual string DelayReasonCode_NV { get; set; }
        /// <summary>
        // Transaction Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("K5", typeof(TELCO_AN))]
        [Pos(37)]
        public virtual string TransactionReferenceNumber_K5 { get; set; }
        /// <summary>
        // Patient Assignment Indicator (Direct Member Reimbursement Indicator)
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("MT", typeof(TELCO_ID_MT))]
        [Pos(38)]
        public virtual string PatientAssignmentIndicator_MT { get; set; }
        /// <summary>
        // Route of Administration
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("E2", typeof(TELCO_AN))]
        [Pos(39)]
        public virtual string RouteOfAdministration_E2 { get; set; }
        /// <summary>
        // Compound Type
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("G1", typeof(TELCO_ID_G1))]
        [Pos(40)]
        public virtual string CompoundType_G1 { get; set; }
        /// <summary>
        // Medicaid Subrogation Internal Control Number/Transaction Control Number (ICN/TCN)
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("N4", typeof(TELCO_AN))]
        [Pos(41)]
        public virtual string ControlNumber_N4 { get; set; }
        /// <summary>
        // Pharmacy Service Type
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("U7", typeof(TELCO_ID_U7))]
        [Pos(42)]
        public virtual string PharmacyServiceType_U7 { get; set; }
    }

    /// <summary>
    // DUR/PPS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM08")]
    public class AM08
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // DUR/PPS Code Counter
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(1)]
        public virtual List<C7E> C7E_01 { get; set; }
    }

    /// <summary>
    // Coupon
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM09")]
    public class AM09
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Coupon Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("KE", typeof(TELCO_ID_KE))]
        [Pos(1)]
        public virtual string CouponType_KE { get; set; }
        /// <summary>
        // Coupon Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("ME", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string CouponNumber_ME { get; set; }
        /// <summary>
        // Coupon Value Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("NE", typeof(TELCO_D2))]
        [Pos(3)]
        public virtual string CouponValueAmount_NE { get; set; }
    }

    /// <summary>
    // Compound
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM10")]
    public class AM10
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Compound Dosage Form Description Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("EF", typeof(TELCO_ID_EF))]
        [Pos(1)]
        public virtual string CompoundDosageFormDescriptionCode_EF { get; set; }
        /// <summary>
        // Compound Dispensing Unit Form Indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("EG", typeof(TELCO_ID_EG))]
        [Pos(2)]
        public virtual string CompoundDispensingUnitFormIndicator_EG { get; set; }
        /// <summary>
        // Compound Ingredient Component Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("EC", typeof(TELCO_N0))]
        [Pos(3)]
        public virtual string CompoundIngredientComponentCount_EC { get; set; }
        /// <summary>
        // Compound Ingredient Component Count
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<CEC> CEC_04 { get; set; }
    }

    /// <summary>
    // Pricing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM11")]
    public class AM11
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Ingredient Cost Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("D9", typeof(TELCO_D2))]
        [Pos(1)]
        public virtual string IngredientCostSubmitted_D9 { get; set; }
        /// <summary>
        // Dispensing Fee Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("DC", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string DispensingFeeSubmitted_DC { get; set; }
        /// <summary>
        // Professional Service Fee Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("BE", typeof(TELCO_D2))]
        [Pos(3)]
        public virtual string ProfessionalServiceFeeSubmitted_BE { get; set; }
        /// <summary>
        // Patient Paid Amount Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("DX", typeof(TELCO_D2))]
        [Pos(4)]
        public virtual string PatientPaidAmountSubmitted_DX { get; set; }
        /// <summary>
        // Incentive Amount Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("E3", typeof(TELCO_D2))]
        [Pos(5)]
        public virtual string IncentiveAmountSubmitted_E3 { get; set; }
        /// <summary>
        // Other Amount Claimed Submitted Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("H7", typeof(TELCO_N0))]
        [Pos(6)]
        public virtual string OtherAmountClaimedSubmittedCount_H7 { get; set; }
        /// <summary>
        // Other Amount Claimed Submitted Count
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<CH7> CH7_07 { get; set; }
        /// <summary>
        // Flat Sales Tax Amount Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("HA", typeof(TELCO_D2))]
        [Pos(8)]
        public virtual string FlatSalesTaxAmountSubmitted_HA { get; set; }
        /// <summary>
        // Percentage Sales Tax Amount Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("GE", typeof(TELCO_D2))]
        [Pos(9)]
        public virtual string PercentageSalesTaxAmountSubmitted_GE { get; set; }
        /// <summary>
        // Percentage Sales Tax Rate Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("HE", typeof(TELCO_D4))]
        [Pos(10)]
        public virtual string PercentageSalesTaxRateSubmitted_HE { get; set; }
        /// <summary>
        // Percentage Sales Tax Basis Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("JE", typeof(TELCO_ID_JE))]
        [Pos(11)]
        public virtual string PercentageSalesTaxBasisSubmitted_JE { get; set; }
        /// <summary>
        // Usual and Customary Charge
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("DQ", typeof(TELCO_D2))]
        [Pos(12)]
        public virtual string UsualAndCustomaryCharge_DQ { get; set; }
        /// <summary>
        // Gross Amount Due
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("DU", typeof(TELCO_D2))]
        [Pos(13)]
        public virtual string GrossAmountDue_DU { get; set; }
        /// <summary>
        // Basis Of Cost Determination
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("DN", typeof(TELCO_ID_DN))]
        [Pos(14)]
        public virtual string BasisOfCostDetermination_DN { get; set; }
        /// <summary>
        // Medicaid Paid Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("N3", typeof(TELCO_D2))]
        [Pos(15)]
        public virtual string MedicaidPaidAmount_N3 { get; set; }
    }

    /// <summary>
    // Prior Authorization
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM12")]
    public class AM12
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Request Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("PA", typeof(TELCO_ID_PA))]
        [Pos(1)]
        public virtual string RequestType_PA { get; set; }
        /// <summary>
        // Request Period Date-Begin
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("PB", typeof(TELCO_DT))]
        [Pos(2)]
        public virtual string RequestPeriodDateBegin_PB { get; set; }
        /// <summary>
        // Request Period Date-End
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("PC", typeof(TELCO_DT))]
        [Pos(3)]
        public virtual string RequestPeriodDateEnd_PC { get; set; }
        /// <summary>
        // Basis Of Request
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("PD", typeof(TELCO_ID_PD))]
        [Pos(4)]
        public virtual string BasisOfRequest_PD { get; set; }
        /// <summary>
        // Authorized Representative First Name
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("PE", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string AuthorizedRepresentativeFirstName_PE { get; set; }
        /// <summary>
        // Authorized Representative Last Name
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("PF", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string AuthorizedRepresentativeLastName_PF { get; set; }
        /// <summary>
        // Authorized Representative Street Address
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("PG", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string AuthorizedRepresentativeStreetAddress_PG { get; set; }
        /// <summary>
        // Authorized Representative City Address
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("PH", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string AuthorizedRepresentativeCityAddress_PH { get; set; }
        /// <summary>
        // Authorized Representative State/Province Address
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("PJ", typeof(TELCO_ID_PJ))]
        [Pos(9)]
        public virtual string AuthorizedRepresentativeStateProvinceAddress_PJ { get; set; }
        /// <summary>
        // Authorized Representative Zip/Postal Zone
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("PK", typeof(TELCO_AN))]
        [Pos(10)]
        public virtual string AuthorizedRepresentativeZipPostalZone_PK { get; set; }
        /// <summary>
        // Prior Authorization Number-Assigned
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("PY", typeof(TELCO_N0))]
        [Pos(11)]
        public virtual string PriorAuthorizationNumberAssigned_PY { get; set; }
        /// <summary>
        // Authorization Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("F3", typeof(TELCO_AN))]
        [Pos(12)]
        public virtual string AuthorizationNumber_F3 { get; set; }
        /// <summary>
        // Prior Authorization Supporting Documentation
        /// </summary>
        [DataMember]
        [StringLength(1, 500)]
        [DataElement("PP", typeof(TELCO_AN))]
        [Pos(13)]
        public virtual string PriorAuthorizationSupportingDocumentation_PP { get; set; }
    }

    /// <summary>
    // Clinical
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM13")]
    public class AM13
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Diagnosis Code Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("VE", typeof(TELCO_N0))]
        [Pos(1)]
        public virtual string DiagnosisCodeCount_VE { get; set; }
        /// <summary>
        // Diagnosis Code Count
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<CVE> CVE_02 { get; set; }
        /// <summary>
        // Clinical Information Counter
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<CXE> CXE_03 { get; set; }
    }

    /// <summary>
    // Additional Documentation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM14")]
    public class AM14
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Additional Documentation Type ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("2Q", typeof(TELCO_ID_2Q))]
        [Pos(1)]
        public virtual string AdditionalDocumentationTypeID_2Q { get; set; }
        /// <summary>
        // Request Period Begin Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("2V", typeof(TELCO_DT))]
        [Pos(2)]
        public virtual string RequestPeriodBeginDate_2V { get; set; }
        /// <summary>
        // Request Period Recert/Revised Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("2W", typeof(TELCO_DT))]
        [Pos(3)]
        public virtual string RequestPeriodRecertRevisedDate_2W { get; set; }
        /// <summary>
        // Request Status
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("2U", typeof(TELCO_ID_2U))]
        [Pos(4)]
        public virtual string RequestStatus_2U { get; set; }
        /// <summary>
        // Length of Need Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2S", typeof(TELCO_ID_2S))]
        [Pos(5)]
        public virtual string LengthOfNeedQualifier_2S { get; set; }
        /// <summary>
        // Length of Need
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2R", typeof(TELCO_N0))]
        [Pos(6)]
        public virtual string LengthOfNeed_2R { get; set; }
        /// <summary>
        // Prescriber/Supplier Date Signed
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("2T", typeof(TELCO_N0))]
        [Pos(7)]
        public virtual string PrescriberSupplierDateSigned_2T { get; set; }
        /// <summary>
        // Supporting Documentation
        /// </summary>
        [DataMember]
        [StringLength(1, 65)]
        [DataElement("2X", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string SupportingDocumentation_2X { get; set; }
        /// <summary>
        // Question Number/Letter Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2Z", typeof(TELCO_N0))]
        [Pos(9)]
        public virtual string QuestionNumberLetterCount_2Z { get; set; }
        /// <summary>
        // Question Number/Letter Count
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(10)]
        public virtual List<C2Z> C2Z_10 { get; set; }
    }

    /// <summary>
    // Facility
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM15")]
    public class AM15
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Facility ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8C", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string FacilityID_8C { get; set; }
        /// <summary>
        // Facility Name
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("3Q", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string FacilityName_3Q { get; set; }
        /// <summary>
        // Facility Street Address
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("3U", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string FacilityStreetAddress_3U { get; set; }
        /// <summary>
        // Facility City Address
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5J", typeof(TELCO_AN))]
        [Pos(4)]
        public virtual string FacilityCityAddress_5J { get; set; }
        /// <summary>
        // Facility State/Province Address
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3V", typeof(TELCO_ID_3V))]
        [Pos(5)]
        public virtual string FacilityStateProvinceAddress_3V { get; set; }
        /// <summary>
        // Facility Zip/Postal Zone
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6D", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string FacilityZipPostalZone_6D { get; set; }
    }

    /// <summary>
    // Narrative
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM16")]
    public class AM16
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Narrative Message
        /// </summary>
        [DataMember]
        [StringLength(1, 200)]
        [DataElement("BM", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string NarrativeMessage_BM { get; set; }
    }

    /// <summary>
    // Response Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM20")]
    public class AM20
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Message
        /// </summary>
        [DataMember]
        [StringLength(1, 200)]
        [DataElement("F4", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string Message_F4 { get; set; }
    }

    /// <summary>
    // Response Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM21")]
    public class AM21
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Transaction Response Status
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("AN", typeof(TELCO_ID_AN))]
        [Pos(1)]
        public virtual string TransactionResponseStatus_AN { get; set; }
        /// <summary>
        // Authorization Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("F3", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string AuthorizationNumber_F3 { get; set; }
        /// <summary>
        // Reject Count
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("FA", typeof(TELCO_N0))]
        [Pos(3)]
        public virtual string RejectCount_FA { get; set; }
        /// <summary>
        // Reject Count
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<CFA> CFA_04 { get; set; }
        /// <summary>
        // Approved Message Code Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("5F", typeof(TELCO_N0))]
        [Pos(5)]
        public virtual string ApprovedMessageCodeCount_5F { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<C5F> C5F_06 { get; set; }
        /// <summary>
        // Additional Message Information Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("UF", typeof(TELCO_N0))]
        [Pos(7)]
        public virtual string AdditionalMessageInformationCount_UF { get; set; }
        /// <summary>
        // Additional Message Information Count
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(8)]
        public virtual List<CUF> CUF_08 { get; set; }
        /// <summary>
        // Help Desk Phone Number Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7F", typeof(TELCO_ID_7F))]
        [Pos(9)]
        public virtual string HelpDeskPhoneNumberQualifier_7F { get; set; }
        /// <summary>
        // Help Desk Phone Number
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("8F", typeof(TELCO_AN))]
        [Pos(10)]
        public virtual string HelpDeskPhoneNumber_8F { get; set; }
        /// <summary>
        // Transaction Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("K5", typeof(TELCO_AN))]
        [Pos(11)]
        public virtual string TransactionReferenceNumber_K5 { get; set; }
        /// <summary>
        // Internal Control Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("A7", typeof(TELCO_AN))]
        [Pos(12)]
        public virtual string InternalControlNumber_A7 { get; set; }
        /// <summary>
        // URL
        /// </summary>
        [DataMember]
        [StringLength(1, 255)]
        [DataElement("MA", typeof(TELCO_AN))]
        [Pos(13)]
        public virtual string URL_MA { get; set; }
    }

    /// <summary>
    // Response Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM22")]
    public class AM22
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Prescription/Service Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("EM", typeof(TELCO_ID_EM))]
        [Pos(1)]
        public virtual string PrescriptionServiceReferenceNumberQualifier_EM { get; set; }
        /// <summary>
        // Prescription/Service Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("D2", typeof(TELCO_N0))]
        [Pos(2)]
        public virtual string PrescriptionServiceReferenceNumber_D2 { get; set; }
        /// <summary>
        // Preferred Product Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9F", typeof(TELCO_N0))]
        [Pos(3)]
        public virtual string PreferredProductCount_9F { get; set; }
        /// <summary>
        // Preferred Product Count
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<C9F> C9F_04 { get; set; }
        /// <summary>
        // Medicaid Subrogation Internal Control Number/Transaction Control Number (ICN/TCN)
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("N4", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string ControlNumber_N4 { get; set; }
    }

    /// <summary>
    // Response Pricing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM23")]
    public class AM23
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Patient Pay Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("F5", typeof(TELCO_D2))]
        [Pos(1)]
        public virtual string PatientPayAmount_F5 { get; set; }
        /// <summary>
        // Ingredient Cost Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("F6", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string IngredientCostPaid_F6 { get; set; }
        /// <summary>
        // Dispensing Fee Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("F7", typeof(TELCO_D2))]
        [Pos(3)]
        public virtual string DispensingFeePaid_F7 { get; set; }
        /// <summary>
        // Tax Exempt Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("AV", typeof(TELCO_ID_AV))]
        [Pos(4)]
        public virtual string TaxExemptIndicator_AV { get; set; }
        /// <summary>
        // Flat Sales Tax Amount Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("AW", typeof(TELCO_D2))]
        [Pos(5)]
        public virtual string FlatSalesTaxAmountPaid_AW { get; set; }
        /// <summary>
        // Percentage Sales Tax Amount Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("AX", typeof(TELCO_D2))]
        [Pos(6)]
        public virtual string PercentageSalesTaxAmountPaid_AX { get; set; }
        /// <summary>
        // Percentage Sales Tax Rate Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("AY", typeof(TELCO_D4))]
        [Pos(7)]
        public virtual string PercentageSalesTaxRatePaid_AY { get; set; }
        /// <summary>
        // Percentage Sales Tax Basis Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("AZ", typeof(TELCO_ID_AZ))]
        [Pos(8)]
        public virtual string PercentageSalesTaxBasisPaid_AZ { get; set; }
        /// <summary>
        // Incentive Amount Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FL", typeof(TELCO_D2))]
        [Pos(9)]
        public virtual string IncentiveAmountPaid_FL { get; set; }
        /// <summary>
        // Professional Service Fee Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("J1", typeof(TELCO_D2))]
        [Pos(10)]
        public virtual string ProfessionalServiceFeePaid_J1 { get; set; }
        /// <summary>
        // Other Amount Paid Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("J2", typeof(TELCO_N0))]
        [Pos(11)]
        public virtual string OtherAmountPaidCount_J2 { get; set; }
        /// <summary>
        // Other Amount Paid Count
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(12)]
        public virtual List<CJ2> CJ2_12 { get; set; }
        /// <summary>
        // Other Payer Amount Recognized
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("J5", typeof(TELCO_D2))]
        [Pos(13)]
        public virtual string OtherPayerAmountRecognized_J5 { get; set; }
        /// <summary>
        // Total Amount Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("F9", typeof(TELCO_D2))]
        [Pos(14)]
        public virtual string TotalAmountPaid_F9 { get; set; }
        /// <summary>
        // Basis Of Reimbursement Determination
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("FM", typeof(TELCO_ID_FM))]
        [Pos(15)]
        public virtual string BasisOfReimbursementDetermination_FM { get; set; }
        /// <summary>
        // Amount Attributed To Sales Tax
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FN", typeof(TELCO_D2))]
        [Pos(16)]
        public virtual string AmountAttributedToSalesTax_FN { get; set; }
        /// <summary>
        // Accumulated Deductible Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FC", typeof(TELCO_D2))]
        [Pos(17)]
        public virtual string AccumulatedDeductibleAmount_FC { get; set; }
        /// <summary>
        // Remaining Deductible Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FD", typeof(TELCO_D2))]
        [Pos(18)]
        public virtual string RemainingDeductibleAmount_FD { get; set; }
        /// <summary>
        // Remaining Benefit Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FE", typeof(TELCO_D2))]
        [Pos(19)]
        public virtual string RemainingBenefitAmount_FE { get; set; }
        /// <summary>
        // Amount Applied To Periodic Deductible
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FH", typeof(TELCO_D2))]
        [Pos(20)]
        public virtual string AmountAppliedToPeriodicDeductible_FH { get; set; }
        /// <summary>
        // Amount Of Copay
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FI", typeof(TELCO_D2))]
        [Pos(21)]
        public virtual string AmountOfCopay_FI { get; set; }
        /// <summary>
        // Amount Exceeding Periodic Benefit Maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FK", typeof(TELCO_D2))]
        [Pos(22)]
        public virtual string AmountExceedingPeriodicBenefitMaximum_FK { get; set; }
        /// <summary>
        // Basis Of Calculation-Dispensing Fee
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("HH", typeof(TELCO_ID_HH))]
        [Pos(23)]
        public virtual string BasisOfCalculationDispensingFee_HH { get; set; }
        /// <summary>
        // Basis Of Calculation-Copay
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("HJ", typeof(TELCO_ID_HJ))]
        [Pos(24)]
        public virtual string BasisOfCalculationCopay_HJ { get; set; }
        /// <summary>
        // Basis Of Calculation-Flat Sales Tax
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("HK", typeof(TELCO_ID_HK))]
        [Pos(25)]
        public virtual string BasisOfCalculationFlatSalesTax_HK { get; set; }
        /// <summary>
        // Basis Of Calculation-Percentage Sales Tax
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("HM", typeof(TELCO_ID_HM))]
        [Pos(26)]
        public virtual string BasisOfCalculationPercentageSalesTax_HM { get; set; }
        /// <summary>
        // Amount Attributed to Processor Fee
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("NZ", typeof(TELCO_D2))]
        [Pos(27)]
        public virtual string AmountAttributedToProcessorFee_NZ { get; set; }
        /// <summary>
        // Patient Sales Tax Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("EQ", typeof(TELCO_D2))]
        [Pos(28)]
        public virtual string PatientSalesTaxAmount_EQ { get; set; }
        /// <summary>
        // Plan Sales Tax Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("2Y", typeof(TELCO_D2))]
        [Pos(29)]
        public virtual string PlanSalesTaxAmount_2Y { get; set; }
        /// <summary>
        // Amount of Coinsurance
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("4U", typeof(TELCO_D2))]
        [Pos(30)]
        public virtual string AmountOfCoinsurance_4U { get; set; }
        /// <summary>
        // Basis of Calculation-Coinsurance
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("4V", typeof(TELCO_ID_4V))]
        [Pos(31)]
        public virtual string BasisOfCalculationCoinsurance_4V { get; set; }
        /// <summary>
        // Benefit Stage Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("MU", typeof(TELCO_N0))]
        [Pos(32)]
        public virtual string BenefitStageCount_MU { get; set; }
        /// <summary>
        // Benefit Stage Count
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(33)]
        public virtual List<CMU> CMU_33 { get; set; }
        /// <summary>
        // Estimated Generic Savings
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("G3", typeof(TELCO_D2))]
        [Pos(34)]
        public virtual string EstimatedGenericSavings_G3 { get; set; }
        /// <summary>
        // Spending Account Amount Remaining
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UC", typeof(TELCO_D2))]
        [Pos(35)]
        public virtual string SpendingAccountAmountRemaining_UC { get; set; }
        /// <summary>
        // Health Plan-funded Assistance Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UD", typeof(TELCO_D2))]
        [Pos(36)]
        public virtual string HealthPlanfundedAssistanceAmount_UD { get; set; }
        /// <summary>
        // Amount Attributed to Provider Network Selection
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UJ", typeof(TELCO_D2))]
        [Pos(37)]
        public virtual string AmountAttributedToProviderNetworkSelection_UJ { get; set; }
        /// <summary>
        // Amount Attributed to Product Selection/Brand Drug
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UK", typeof(TELCO_D2))]
        [Pos(38)]
        public virtual string AmountAttributedToProductSelection_UK { get; set; }
        /// <summary>
        // Amount Attributed to Product Selection/Non-Preferred Formulary Selection
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UM", typeof(TELCO_D2))]
        [Pos(39)]
        public virtual string AmountAttributedToNonPreferredFormularySelection_UM { get; set; }
        /// <summary>
        // Amount Attributed to Product Selection/Brand Non-Preferred Formulary Selection
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UN", typeof(TELCO_D2))]
        [Pos(40)]
        public virtual string AmountAttributedToNonPreferredFormularySelection_UN { get; set; }
        /// <summary>
        // Amount Attributed to Coverage Gap
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UP", typeof(TELCO_D2))]
        [Pos(41)]
        public virtual string AmountAttributedToCoverageGap_UP { get; set; }
        /// <summary>
        // Ingredient Cost Contracted/Reimbursable Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("U8", typeof(TELCO_D2))]
        [Pos(42)]
        public virtual string IngredientCostContractedReimbursableAmount_U8 { get; set; }
        /// <summary>
        // Dispensing Fee Contracted/Reimbursable Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("U9", typeof(TELCO_D2))]
        [Pos(43)]
        public virtual string DispensingFeeContractedReimbursableAmount_U9 { get; set; }
    }

    /// <summary>
    // Response DUR/PPS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM24")]
    public class AM24
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // DUR/PPS Response Code Counter
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(1)]
        public virtual List<CJ6> CJ6_01 { get; set; }
    }

    /// <summary>
    // Response Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM25")]
    public class AM25
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Group ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("C1", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string GroupID_C1 { get; set; }
        /// <summary>
        // Plan ID
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FO", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string PlanID_FO { get; set; }
        /// <summary>
        // Network Reimbursement ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("2F", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string NetworkReimbursementID_2F { get; set; }
        /// <summary>
        // Payer ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("J7", typeof(TELCO_ID_J7))]
        [Pos(4)]
        public virtual string PayerIDQualifier_J7 { get; set; }
        /// <summary>
        // Payer ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("J8", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string PayerID_J8 { get; set; }
        /// <summary>
        // Medicaid ID Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("N5", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string MedicaidIDNumber_N5 { get; set; }
        /// <summary>
        // Medicaid Agency Number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("N6", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string MedicaidAgencyNumber_N6 { get; set; }
        /// <summary>
        // Cardholder ID
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("C2", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string CardholderID_C2 { get; set; }
    }

    /// <summary>
    // Response Prior Authorization
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM26")]
    public class AM26
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Prior Authorization Processed Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("PR", typeof(TELCO_DT))]
        [Pos(1)]
        public virtual string PriorAuthorizationProcessedDate_PR { get; set; }
        /// <summary>
        // Prior Authorization Effective Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("PS", typeof(TELCO_N0))]
        [Pos(2)]
        public virtual string PriorAuthorizationEffectiveDate_PS { get; set; }
        /// <summary>
        // Prior Authorization Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("PT", typeof(TELCO_N0))]
        [Pos(3)]
        public virtual string PriorAuthorizationExpirationDate_PT { get; set; }
        /// <summary>
        // Prior Authorization Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("RA", typeof(TELCO_N3))]
        [Pos(4)]
        public virtual string PriorAuthorizationQuantity_RA { get; set; }
        /// <summary>
        // Prior Authorization Dollars Authorized
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("RB", typeof(TELCO_D2))]
        [Pos(5)]
        public virtual string PriorAuthorizationDollarsAuthorized_RB { get; set; }
        /// <summary>
        // Prior Authorization Number Of Refills Authorized
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("PW", typeof(TELCO_N0))]
        [Pos(6)]
        public virtual string PriorAuthorizationNumberOfRefillsAuthorized_PW { get; set; }
        /// <summary>
        // Prior Authorization Quantity Accumulated
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("PX", typeof(TELCO_N3))]
        [Pos(7)]
        public virtual string PriorAuthorizationQuantityAccumulated_PX { get; set; }
        /// <summary>
        // Prior Authorization Number-Assigned
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("PY", typeof(TELCO_N0))]
        [Pos(8)]
        public virtual string PriorAuthorizationNumberAssigned_PY { get; set; }
    }

    /// <summary>
    // Response Insurance Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM27")]
    public class AM27
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Medicare Part D Coverage Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("UR", typeof(TELCO_ID_UR))]
        [Pos(1)]
        public virtual string MedicarePartDCoverageCode_UR { get; set; }
        /// <summary>
        // CMS Low Income Cost Sharing (LICS) Level
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("UQ", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string CMSLowIncomeCostSharing_UQ { get; set; }
        /// <summary>
        // Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("U1", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string ContractNumber_U1 { get; set; }
        /// <summary>
        // Formulary ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("FF", typeof(TELCO_AN))]
        [Pos(4)]
        public virtual string FormularyID_FF { get; set; }
        /// <summary>
        // Benefit ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("U6", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string BenefitID_U6 { get; set; }
        /// <summary>
        // Next Medicare Part D Effective Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("US", typeof(TELCO_DT))]
        [Pos(6)]
        public virtual string NextMedicarePartDEffectiveDate_US { get; set; }
        /// <summary>
        // Next Medicare Part D Termination Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UT", typeof(TELCO_DT))]
        [Pos(7)]
        public virtual string NextMedicarePartDTerminationDate_UT { get; set; }
    }

    /// <summary>
    // Response Coordination of Benefits/Other Payers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM28")]
    public class AM28
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Payer ID Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("NT", typeof(TELCO_N0))]
        [Pos(1)]
        public virtual string OtherPayerIDCount_NT { get; set; }
        /// <summary>
        // Other Payer ID Count
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<CNT> CNT_02 { get; set; }
    }

    /// <summary>
    // Response Patient
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AM29")]
    public class AM29
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Patient First Name
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("CA", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string PatientFirstName_CA { get; set; }
        /// <summary>
        // Patient Last Name
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("CB", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string PatientLastName_CB { get; set; }
        /// <summary>
        // Date Of Birth
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("C4", typeof(TELCO_DT))]
        [Pos(3)]
        public virtual string DateOfBirth_C4 { get; set; }
    }
}
