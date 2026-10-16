namespace EdiFabric.Templates.TelcoD0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Telco;


    /// <summary>
    // Billing Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("TELCO", "B1")]
    public class TSB1 : EdiMessage
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Transaction Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TransactionHeader G1 { get; set; }
        /// <summary>
        // Insurance
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual Loop_AM04_TSB1 AM04Loop { get; set; }
        /// <summary>
        // Claim
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<Loop_AM07_TSB1> AM07Loop { get; set; }
    }

    /// <summary>
    // Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [All()]
    public class Loop_AM04_TSB1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Insurance
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AM04 AM04 { get; set; }
        /// <summary>
        // Patient
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AM01 AM01 { get; set; }
    }

    /// <summary>
    // Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [All()]
    public class Loop_AM07_TSB1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Claim
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AM07 AM07 { get; set; }
        /// <summary>
        // Pricing
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AM11 AM11 { get; set; }
        /// <summary>
        // Pharmacy Provider
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AM02 AM02 { get; set; }
        /// <summary>
        // Prescriber
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AM03 AM03 { get; set; }
        /// <summary>
        // Coordination of Benefits/Other Payments
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AM05 AM05 { get; set; }
        /// <summary>
        // Workers' Compensation
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AM06 AM06 { get; set; }
        /// <summary>
        // DUR/PPS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AM08 AM08 { get; set; }
        /// <summary>
        // Coupon
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual AM09 AM09 { get; set; }
        /// <summary>
        // Compound
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AM10 AM10 { get; set; }
        /// <summary>
        // Clinical
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual AM13 AM13 { get; set; }
        /// <summary>
        // Additional Documentation
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AM14 AM14 { get; set; }
        /// <summary>
        // Facility
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual AM15 AM15 { get; set; }
        /// <summary>
        // Narrative
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual AM16 AM16 { get; set; }
    }
}
