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

    [Serializable()]
    [DataContract()]
    [Message("TELCO", "RESPONSE")]
    public class TSRESPONSE : EdiMessage
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
        public virtual ResponseHeader G1 { get; set; }
        /// <summary>
        // Response Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual Loop_AM20_TSRESPONSE AM20Loop { get; set; }
        /// <summary>
        // Response Status
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<Loop_AM21_TSRESPONSE> AM21Loop { get; set; }
    }

    /// <summary>
    // Response Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AM20))]
    public class Loop_AM20_TSRESPONSE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Response Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AM20 AM20 { get; set; }
        /// <summary>
        // Response Insurance
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AM25 AM25 { get; set; }
        /// <summary>
        // Response Insurance Additional Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AM27 AM27 { get; set; }
        /// <summary>
        // Response Patient
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AM29 AM29 { get; set; }
    }

    /// <summary>
    // Response Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AM21))]
    public class Loop_AM21_TSRESPONSE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Response Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AM21 AM21 { get; set; }
        /// <summary>
        // Response Claim
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AM22 AM22 { get; set; }
        /// <summary>
        // Response Pricing
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AM23 AM23 { get; set; }
        /// <summary>
        // Response DUR/PPS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AM24 AM24 { get; set; }
        /// <summary>
        // Response Prior Authorization
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AM26 AM26 { get; set; }
        /// <summary>
        // Response Coordination of Benefits/Other Payers
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AM28 AM28 { get; set; }
    }
}
