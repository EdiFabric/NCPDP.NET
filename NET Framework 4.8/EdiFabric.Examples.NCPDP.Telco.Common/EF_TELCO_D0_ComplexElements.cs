namespace EdiFabric.Templates.TelcoD0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Telco;

    [Serializable()]
    [DataContract()]
    [Composite("C2G")]
    public class C2G
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Compound Ingredient Modifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2H", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string CompoundIngredientModifierCode_2H { get; set; }
    }

    /// <summary>
    // Question Number/Letter Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C2Z")]
    public class C2Z
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Question Number/Letter
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4B", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string QuestionNumberLetter_4B { get; set; }
        /// <summary>
        // Question Percent Response
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("4D", typeof(TELCO_N2))]
        [Pos(2)]
        public virtual string QuestionPercentResponse_4D { get; set; }
        /// <summary>
        // Question Date Response
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("4G", typeof(TELCO_DT))]
        [Pos(3)]
        public virtual string QuestionDateResponse_4G { get; set; }
        /// <summary>
        // Question Dollar Amount Response
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("4H", typeof(TELCO_D2))]
        [Pos(4)]
        public virtual string QuestionDollarAmountResponse_4H { get; set; }
        /// <summary>
        // Question Numeric Response
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("4J", typeof(TELCO_N0))]
        [Pos(5)]
        public virtual string QuestionNumericResponse_4J { get; set; }
        /// <summary>
        // Question Alphanumeric Response
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("4K", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string QuestionAlphanumericResponse_4K { get; set; }
    }

    /// <summary>
    // Coordination of Benefits/Other Payments Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C4C")]
    public class C4C
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Payer Coverage Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("5C", typeof(TELCO_ID_5C))]
        [Pos(1)]
        public virtual string OtherPayerCoverageType_5C { get; set; }
        /// <summary>
        // Other Payer ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6C", typeof(TELCO_ID_6C))]
        [Pos(2)]
        public virtual string OtherPayerIDQualifier_6C { get; set; }
        /// <summary>
        // Other Payer ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("7C", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string OtherPayerID_7C { get; set; }
        /// <summary>
        // Other Payer Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("E8", typeof(TELCO_DT))]
        [Pos(4)]
        public virtual string OtherPayerDate_E8 { get; set; }
        /// <summary>
        // Internal Control Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("A7", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string InternalControlNumber_A7 { get; set; }
        /// <summary>
        // Other Payer Amount Paid Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("HB", typeof(TELCO_N0))]
        [Pos(6)]
        public virtual string OtherPayerAmountPaidCount_HB { get; set; }
        /// <summary>
        // Other Payer Amount Paid Count
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<CHB> CHB_07 { get; set; }
        /// <summary>
        // Other Payer Reject Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("5E", typeof(TELCO_N0))]
        [Pos(8)]
        public virtual string OtherPayerRejectCount_5E { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<C5E> C5E_09 { get; set; }
        /// <summary>
        // Other Payer-Patient Responsibility Amount Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("NR", typeof(TELCO_N0))]
        [Pos(10)]
        public virtual string OtherPayerPatientResponsibilityAmountCount_NR { get; set; }
        /// <summary>
        // Other Payer-Patient Responsibility Amount Count
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(11)]
        public virtual List<CNR> CNR_11 { get; set; }
        /// <summary>
        // Benefit Stage Count
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("MU", typeof(TELCO_N0))]
        [Pos(12)]
        public virtual string BenefitStageCount_MU { get; set; }
        /// <summary>
        // Benefit Stage Count
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(13)]
        public virtual List<CMU> CMU_13 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Composite("C5E")]
    public class C5E
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Payer Reject Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6E", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string OtherPayerRejectCode_6E { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Composite("C5F")]
    public class C5F
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Approved Message Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6F", typeof(TELCO_ID_6F))]
        [Pos(1)]
        public virtual string ApprovedMessageCode_6F { get; set; }
    }

    /// <summary>
    // Preferred Product Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C9F")]
    public class C9F
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Preferred Product ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("AP", typeof(TELCO_ID_AP))]
        [Pos(1)]
        public virtual string PreferredProductIDQualifier_AP { get; set; }
        /// <summary>
        // Preferred Product ID
        /// </summary>
        [DataMember]
        [StringLength(1, 19)]
        [DataElement("AR", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string PreferredProductID_AR { get; set; }
        /// <summary>
        // Preferred Product Incentive
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("AS", typeof(TELCO_D2))]
        [Pos(3)]
        public virtual string PreferredProductIncentive_AS { get; set; }
        /// <summary>
        // Preferred Product Cost Share Incentive
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("AT", typeof(TELCO_D2))]
        [Pos(4)]
        public virtual string PreferredProductCostShareIncentive_AT { get; set; }
        /// <summary>
        // Preferred Product Description
        /// </summary>
        [DataMember]
        [StringLength(1, 40)]
        [DataElement("AU", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string PreferredProductDescription_AU { get; set; }
    }

    /// <summary>
    // Compound Ingredient Component Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CEC")]
    public class CEC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Compound Product ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("RE", typeof(TELCO_ID_RE))]
        [Pos(1)]
        public virtual string CompoundProductIDQualifier_RE { get; set; }
        /// <summary>
        // Compound Product ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 19)]
        [DataElement("TE", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string CompoundProductID_TE { get; set; }
        /// <summary>
        // Compound Ingredient Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("ED", typeof(TELCO_N3))]
        [Pos(3)]
        public virtual string CompoundIngredientQuantity_ED { get; set; }
        /// <summary>
        // Compound Ingredient Drug Cost
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("EE", typeof(TELCO_D2))]
        [Pos(4)]
        public virtual string CompoundIngredientDrugCost_EE { get; set; }
        /// <summary>
        // Compound Ingredient Basis of Cost Determination
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("UE", typeof(TELCO_ID_UE))]
        [Pos(5)]
        public virtual string CompoundIngredientBasisofCostDetermination_UE { get; set; }
        /// <summary>
        // Compound Ingredient Modifier Code Count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("2G", typeof(TELCO_N0))]
        [Pos(6)]
        public virtual string CompoundIngredientModifierCodeCount_2G { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<C2G> C2G_07 { get; set; }
    }

    /// <summary>
    // Reject Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CFA")]
    public class CFA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Reject Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("FB", typeof(TELCO_ID_FB))]
        [Pos(1)]
        public virtual string RejectCode_FB { get; set; }
        /// <summary>
        // Rejected Field Occurrence Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("4F", typeof(TELCO_N0))]
        [Pos(2)]
        public virtual string RejectedFieldOccurrenceIndicator_4F { get; set; }
    }

    /// <summary>
    // Other Amount Claimed Submitted Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CH7")]
    public class CH7
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Amount Claimed Submitted Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("H8", typeof(TELCO_ID_H8))]
        [Pos(1)]
        public virtual string OtherAmountClaimedSubmittedQualifier_H8 { get; set; }
        /// <summary>
        // Other Amount Claimed Submitted
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("H9", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string OtherAmountClaimedSubmitted_H9 { get; set; }
    }

    /// <summary>
    // Other Payer Amount Paid Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CHB")]
    public class CHB
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Payer Amount Paid Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("HC", typeof(TELCO_ID_HC))]
        [Pos(1)]
        public virtual string OtherPayerAmountPaidQualifier_HC { get; set; }
        /// <summary>
        // Other Payer Amount Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("DV", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string OtherPayerAmountPaid_DV { get; set; }
    }

    /// <summary>
    // Other Amount Paid Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CJ2")]
    public class CJ2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Amount Paid Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("J3", typeof(TELCO_ID_J3))]
        [Pos(1)]
        public virtual string OtherAmountPaidQualifier_J3 { get; set; }
        /// <summary>
        // Other Amount Paid
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("J4", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string OtherAmountPaid_J4 { get; set; }
    }

    /// <summary>
    // Benefit Stage Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CMU")]
    public class CMU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Benefit Stage Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("MV", typeof(TELCO_ID_MV))]
        [Pos(1)]
        public virtual string BenefitStageQualifier_MV { get; set; }
        /// <summary>
        // Benefit Stage Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("MW", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string BenefitStageAmount_MW { get; set; }
    }

    /// <summary>
    // Other Payer-Patient Responsibility Amount Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CNR")]
    public class CNR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Payer-Patient Responsibility Amount Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("NP", typeof(TELCO_ID_NP))]
        [Pos(1)]
        public virtual string OtherPayerPatientResponsibilityAmountQualifier_NP { get; set; }
        /// <summary>
        // Other Payer-Patient Responsibility Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("NQ", typeof(TELCO_D2))]
        [Pos(2)]
        public virtual string OtherPayerPatientResponsibilityAmount_NQ { get; set; }
    }

    /// <summary>
    // Other Payer ID Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CNT")]
    public class CNT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Other Payer Coverage Type
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("5C", typeof(TELCO_ID_5C))]
        [Pos(1)]
        public virtual string OtherPayerCoverageType_5C { get; set; }
        /// <summary>
        // Other Payer ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6C", typeof(TELCO_ID_6C))]
        [Pos(2)]
        public virtual string OtherPayerIDQualifier_6C { get; set; }
        /// <summary>
        // Other Payer ID
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("7C", typeof(TELCO_AN))]
        [Pos(3)]
        public virtual string OtherPayerID_7C { get; set; }
        /// <summary>
        // Other Payer Processor Control Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("MH", typeof(TELCO_AN))]
        [Pos(4)]
        public virtual string OtherPayerProcessorControlNumber_MH { get; set; }
        /// <summary>
        // Other Payer Cardholder ID
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("NU", typeof(TELCO_AN))]
        [Pos(5)]
        public virtual string OtherPayerCardholderID_NU { get; set; }
        /// <summary>
        // Other Payer Group ID
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("MJ", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string OtherPayerGroupID_MJ { get; set; }
        /// <summary>
        // Other Payer Person Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("UV", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string OtherPayerPersonCode_UV { get; set; }
        /// <summary>
        // Other Payer Help Desk Phone Number
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("UB", typeof(TELCO_AN))]
        [Pos(8)]
        public virtual string OtherPayerHelpDeskPhoneNumber_UB { get; set; }
        /// <summary>
        // Other Payer-Patient Relationship Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("UW", typeof(TELCO_ID_UW))]
        [Pos(9)]
        public virtual string OtherPayerPatientRelationshipCode_UW { get; set; }
        /// <summary>
        // Other Payer Benefit Effective Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UX", typeof(TELCO_DT))]
        [Pos(10)]
        public virtual string OtherPayerBenefitEffectiveDate_UX { get; set; }
        /// <summary>
        // Other Payer Benefit Termination Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("UY", typeof(TELCO_DT))]
        [Pos(11)]
        public virtual string OtherPayerBenefitTerminationDate_UY { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Composite("CNX")]
    public class CNX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Submission Clarification Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("DK", typeof(TELCO_ID_DK))]
        [Pos(1)]
        public virtual string SubmissionClarificationCode_DK { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Composite("CSE")]
    public class CSE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Procedure Modifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("ER", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string ProcedureModifierCode_ER { get; set; }
    }

    /// <summary>
    // Additional Message Information Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CUF")]
    public class CUF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Additional Message Information Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("UH", typeof(TELCO_ID_UH))]
        [Pos(1)]
        public virtual string AdditionalMessageInformationQualifier_UH { get; set; }
        /// <summary>
        // Additional Message Information
        /// </summary>
        [DataMember]
        [StringLength(1, 40)]
        [DataElement("FQ", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string AdditionalMessageInformation_FQ { get; set; }
        /// <summary>
        // Additional Message Information Continuity
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("UG", typeof(TELCO_ID_UG))]
        [Pos(3)]
        public virtual string AdditionalMessageInformationContinuity_UG { get; set; }
    }

    /// <summary>
    // Diagnosis Code Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CVE")]
    public class CVE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Diagnosis Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("WE", typeof(TELCO_ID_WE))]
        [Pos(1)]
        public virtual string DiagnosisCodeQualifier_WE { get; set; }
        /// <summary>
        // Diagnosis Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("DO", typeof(TELCO_AN))]
        [Pos(2)]
        public virtual string DiagnosisCode_DO { get; set; }
    }

    /// <summary>
    // DUR/PPS Code Counter
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C7E")]
    public class C7E
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // DUR/PPS Code Counter
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7E", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string DURPPSCodeCounter_7E { get; set; }
        /// <summary>
        // Reason For Service Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("E4", typeof(TELCO_ID_E4))]
        [Pos(2)]
        public virtual string ReasonForServiceCode_E4 { get; set; }
        /// <summary>
        // Professional Service Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("E5", typeof(TELCO_ID_E5))]
        [Pos(3)]
        public virtual string ProfessionalServiceCode_E5 { get; set; }
        /// <summary>
        // Result of Service Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("E6", typeof(TELCO_ID_E6))]
        [Pos(4)]
        public virtual string ResultofServiceCode_E6 { get; set; }
        /// <summary>
        // DUR/PPS Level Of Effort
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("8E", typeof(TELCO_ID_8E))]
        [Pos(5)]
        public virtual string DURPPSLevelOfEffort_8E { get; set; }
        /// <summary>
        // DUR Co-Agent ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("J9", typeof(TELCO_ID_J9))]
        [Pos(6)]
        public virtual string DURCoAgentIDQualifier_J9 { get; set; }
        /// <summary>
        // DUR Co-Agent ID
        /// </summary>
        [DataMember]
        [StringLength(1, 19)]
        [DataElement("H6", typeof(TELCO_AN))]
        [Pos(7)]
        public virtual string DURCoAgentID_H6 { get; set; }
    }

    /// <summary>
    // DUR/PPS Response Code Counter
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CJ6")]
    public class CJ6
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // DUR/PPS Response Code Counter
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("J6", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string DURPPSResponseCodeCounter_J6 { get; set; }
        /// <summary>
        // Reason For Service Code
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("E4", typeof(TELCO_ID_E4))]
        [Pos(2)]
        public virtual string ReasonForServiceCode_E4 { get; set; }
        /// <summary>
        // Clinical Significance Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("FS", typeof(TELCO_ID_FS))]
        [Pos(3)]
        public virtual string ClinicalSignificanceCode_FS { get; set; }
        /// <summary>
        // Other Pharmacy Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("FT", typeof(TELCO_ID_FT))]
        [Pos(4)]
        public virtual string OtherPharmacyIndicator_FT { get; set; }
        /// <summary>
        // Previous Date of Fill
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("FU", typeof(TELCO_DT))]
        [Pos(5)]
        public virtual string PreviousDateofFill_FU { get; set; }
        /// <summary>
        // Quantity Of Previous Fill
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("FV", typeof(TELCO_N3))]
        [Pos(6)]
        public virtual string QuantityOfPreviousFill_FV { get; set; }
        /// <summary>
        // Database Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("FW", typeof(TELCO_ID_FW))]
        [Pos(7)]
        public virtual string DatabaseIndicator_FW { get; set; }
        /// <summary>
        // Other Prescriber Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("FX", typeof(TELCO_ID_FX))]
        [Pos(8)]
        public virtual string OtherPrescriberIndicator_FX { get; set; }
        /// <summary>
        // DUR Free Text Message
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("FY", typeof(TELCO_AN))]
        [Pos(9)]
        public virtual string DURFreeTextMessage_FY { get; set; }
        /// <summary>
        // DUR Additional Text
        /// </summary>
        [DataMember]
        [StringLength(1, 100)]
        [DataElement("NS", typeof(TELCO_AN))]
        [Pos(10)]
        public virtual string DURAdditionalText_NS { get; set; }
    }

    /// <summary>
    // Clinical Information Counter
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CXE")]
    public class CXE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Clinical Information Counter
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("XE", typeof(TELCO_AN))]
        [Pos(1)]
        public virtual string ClinicalInformationCounter_XE { get; set; }
        /// <summary>
        // Measurement Date
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("ZE", typeof(TELCO_DT))]
        [Pos(2)]
        public virtual string MeasurementDate_ZE { get; set; }
        /// <summary>
        // Measurement Time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("H1", typeof(TELCO_N0))]
        [Pos(3)]
        public virtual string MeasurementTime_H1 { get; set; }
        /// <summary>
        // Measurement Dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("H2", typeof(TELCO_ID_H2))]
        [Pos(4)]
        public virtual string MeasurementDimension_H2 { get; set; }
        /// <summary>
        // Measurement Unit
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("H3", typeof(TELCO_ID_H3))]
        [Pos(5)]
        public virtual string MeasurementUnit_H3 { get; set; }
        /// <summary>
        // Measurement Value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("H4", typeof(TELCO_AN))]
        [Pos(6)]
        public virtual string MeasurementValue_H4 { get; set; }
    }
}
