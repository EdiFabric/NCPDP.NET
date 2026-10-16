namespace EdiFabric.Templates.TelcoD0
{
    using System;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;


    /// <summary>
    // Smoker/Non-Smoker Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class TELCO_ID_1C
    {
    }

    /// <summary>
    // Medicaid Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_2B
    {
    }

    /// <summary>
    // Pregnancy Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class TELCO_ID_2C
    {
    }

    /// <summary>
    // Provider Accept Assignment Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class TELCO_ID_2D
    {
    }

    /// <summary>
    // Primary Care Provider ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,08,09,10,11,12,13,14,15,99,")]
    public class TELCO_ID_2E
    {
    }

    /// <summary>
    // Prescriber State/Province Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_2N
    {
    }

    /// <summary>
    // Additional Documentation Type ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,")]
    public class TELCO_ID_2Q
    {
    }

    /// <summary>
    // Length of Need Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,")]
    public class TELCO_ID_2S
    {
    }

    /// <summary>
    // Request Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class TELCO_ID_2U
    {
    }

    /// <summary>
    // Facility State/Province Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_3V
    {
    }

    /// <summary>
    // Basis of Calculation-Coinsurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,99,")]
    public class TELCO_ID_4V
    {
    }

    /// <summary>
    // Patient Residence
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,")]
    public class TELCO_ID_4X
    {
    }

    /// <summary>
    // Other Payer Coverage Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,")]
    public class TELCO_ID_5C
    {
    }

    /// <summary>
    // Other Payer ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,1C,1D,99,")]
    public class TELCO_ID_6C
    {
    }

    /// <summary>
    // Approved Message Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,")]
    public class TELCO_ID_6F
    {
    }

    /// <summary>
    // Help Desk Phone Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,99,")]
    public class TELCO_ID_7F
    {
    }

    /// <summary>
    // DUR/PPS Level Of Effort
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,11,12,13,14,15,")]
    public class TELCO_ID_8E
    {
    }

    /// <summary>
    // Unit Of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EA,GM,ML,")]
    public class TELCO_ID_28
    {
    }

    /// <summary>
    // Segment Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,20,21,22,23,24,25,26,27,28" +
            ",29,")]
    public class TELCO_ID_AM
    {
    }

    /// <summary>
    // Transaction Response Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,F,P,Q,R,S,")]
    public class TELCO_ID_AN
    {
    }

    /// <summary>
    // Preferred Product ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,11,12,13,14,15,16,17,18,19,28,29,30,31,32,33,99,")]
    public class TELCO_ID_AP
    {
    }

    /// <summary>
    // Tax Exempt Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class TELCO_ID_AV
    {
    }

    /// <summary>
    // Percentage Sales Tax Basis Paid
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",02,03,")]
    public class TELCO_ID_AZ
    {
    }

    /// <summary>
    // Patient Gender Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,")]
    public class TELCO_ID_C5
    {
    }

    /// <summary>
    // Patient Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,")]
    public class TELCO_ID_C6
    {
    }

    /// <summary>
    // Place of Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,11,12,13,14,15,16,20,21,22,23,24,25,26,3,31,32,33,34,4,41,42,49,5,50,51,52,53," +
            "54,55,56,57,6,60,61,62,65,7,71,72,8,81,99,")]
    public class TELCO_ID_C7
    {
    }

    /// <summary>
    // Other Coverage Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,")]
    public class TELCO_ID_C8
    {
    }

    /// <summary>
    // Eligibility Clarification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,")]
    public class TELCO_ID_C9
    {
    }

    /// <summary>
    // Employer State/Province Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_CI
    {
    }

    /// <summary>
    // Patient State/Province Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_CO
    {
    }

    /// <summary>
    // Patient ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,1J,99,EA,")]
    public class TELCO_ID_CX
    {
    }

    /// <summary>
    // Fill Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class TELCO_ID_D3
    {
    }

    /// <summary>
    // Compound Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,")]
    public class TELCO_ID_D6
    {
    }

    /// <summary>
    // Dispense As Written (DAW)/Product Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,")]
    public class TELCO_ID_D8
    {
    }

    /// <summary>
    // Number of Refills Authorized
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class TELCO_ID_DF
    {
    }

    /// <summary>
    // Level Of Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,")]
    public class TELCO_ID_DI
    {
    }

    /// <summary>
    // Prescription Origin Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,")]
    public class TELCO_ID_DJ
    {
    }

    /// <summary>
    // Submission Clarification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
            ",35,36,4,5,6,7,8,9,99,")]
    public class TELCO_ID_DK
    {
    }

    /// <summary>
    // Basis Of Cost Determination
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,")]
    public class TELCO_ID_DN
    {
    }

    /// <summary>
    // Special Packaging Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,")]
    public class TELCO_ID_DT
    {
    }

    /// <summary>
    // Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,15,28,29,30,31,32,33,34,36,99,")]
    public class TELCO_ID_E1
    {
    }

    /// <summary>
    // Reason For Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AN,AR,AT,CD,CH,CS,DA,DC,DD,DF,DI,DL,DM,DR,DS,ED,ER,EX,HD,IC,ID,LD,LK,LR,MC,MN" +
            ",MS,MX,NA,NC,ND,NF,NN,NP,NR,NS,OH,PA,PC,PG,PH,PN,PP,PR,PS,RE,RF,SC,SD,SE,SF,SR,S" +
            "X,TD,TN,TP,UD,")]
    public class TELCO_ID_E4
    {
    }

    /// <summary>
    // Professional Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,AS,CC,DE,DP,FE,GP,M0,MA,MB,MP,MR,P0,PA,PE,PH,PM,PT,R0,RT,SC,SW,TC,TH,")]
    public class TELCO_ID_E5
    {
    }

    /// <summary>
    // Result of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,2A,2B,3A,3B,3C,3D,3E,3F,3G,3H,3J,3K,3M,3N,4A,")]
    public class TELCO_ID_E6
    {
    }

    /// <summary>
    // Compound Dosage Form Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,10,11,12,13,14,15,16,17,18,")]
    public class TELCO_ID_EF
    {
    }

    /// <summary>
    // Compound Dispensing Unit Form Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class TELCO_ID_EG
    {
    }

    /// <summary>
    // Originally Prescribed Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,15,28,29,30,31,32,33,99,")]
    public class TELCO_ID_EJ
    {
    }

    /// <summary>
    // Prescription/Service Reference Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class TELCO_ID_EM
    {
    }

    /// <summary>
    // Prior Authorization Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,")]
    public class TELCO_ID_EU
    {
    }

    /// <summary>
    // Prior Authorization Number Submitted
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",91100000000,91100000001,91100000002,91100000003,91100000004,91100000005,")]
    public class TELCO_ID_EV
    {
    }

    /// <summary>
    // Intermediary Authorization Type ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,99,")]
    public class TELCO_ID_EW
    {
    }

    /// <summary>
    // Provider ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,99,")]
    public class TELCO_ID_EY
    {
    }

    /// <summary>
    // Prescriber ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,08,09,10,11,12,13,14,15,99,")]
    public class TELCO_ID_EZ
    {
    }

    /// <summary>
    // Reject Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,1001,1002,1003,1004,1005,1006,1007,1008,1009,10" +
            "10,1011,1012,1013,11,13,14,15,16,17,19,1C,1E,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22" +
            ",23,25,26,28,29,2A,2B,2C,2D,2E,2G,2H,2J,2K,2M,2N,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Z,3" +
            "2,33,34,35,39,3A,3B,3C,3D,3E,3F,3G,3H,3J,3K,3M,3N,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y," +
            "40,41,4B,4C,4D,4E,4G,4H,4J,4K,4M,4N,4P,4Q,4R,4S,4T,4W,4X,4Y,4Z,50,51,52,53,54,55" +
            ",56,58,5C,5E,5J,60,61,62,63,64,65,66,67,68,69,6C,6D,6E,6G,6H,6J,6K,6M,6N,6P,6Q,6" +
            "R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7G,7H,7J," +
            "7K,7M,7N,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C" +
            ",8D,8E,8G,8H,8J,8K,8M,8N,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,8Z,90,9000,91,92,95,96,97" +
            ",98,99,9B,9C,9D,9E,9G,9H,9J,9K,9M,9N,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A5,A6,A7,A" +
            "9,AA,AB,AC,AD,AE,AF,AG,AH,AJ,AK,AM,AQ,B2,BA,BB,BC,BD,BE,BF,BG,BH,BJ,BK,BM,CA,CB," +
            "CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CW,CX,CY,CZ,DC,DN,DQ,DR,DT,DU,DV" +
            ",DX,DY,DZ,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,EG,EJ,EK,EM,EN,EP,ER,ET,E" +
            "U,EV,EW,EX,EY,EZ,FO,G1,G2,G4,G5,G6,G7,G8,G9,GE,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB," +
            "HC,HD,HE,HF,HG,HN,J9,JE,K5,KE,M1,M2,M3,M4,M5,M6,M7,M8,ME,MG,MH,MJ,MK,MM,MN,MP,MR" +
            ",MS,MT,MU,MV,MW,MX,MY,MZ,N1,N3,N4,N5,N6,N7,N8,N9,NA,NB,NC,ND,NE,NF,NG,NH,NJ,NK,N" +
            "M,NN,NP,NQ,NR,NU,NV,NW,NX,NY,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG," +
            "PH,PJ,PK,PM,PN,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA" +
            ",RB,RC,RD,RF,RG,RH,RJ,RK,RL,RM,RN,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S" +
            "4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SJ,SK,SM,SN,SP,SQ,SW,T0,T1,T2,T3,T4,TD," +
            "TF,TG,TH,TJ,TK,TM,TN,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U0,U7,UA,UU,UZ,V0,VA,VB,VC" +
            ",VD,VE,W0,W5,W6,W7,W8,W9,WE,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9,XE,XZ,Y0,Y1,Y2,Y3,Y4,Y" +
            "5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YG,YH,YJ,YK,YM,YN,YP,YQ,YT,YU,YV,YW,YX,YY,YZ,Z0," +
            "Z2,Z3,Z4,Z5,Z6,Z7,ZA,ZB,ZC,ZD,ZE,ZF,ZN,")]
    public class TELCO_ID_FB
    {
    }

    /// <summary>
    // Basis Of Reimbursement Determination
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
    public class TELCO_ID_FM
    {
    }

    /// <summary>
    // Clinical Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,9,")]
    public class TELCO_ID_FS
    {
    }

    /// <summary>
    // Other Pharmacy Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class TELCO_ID_FT
    {
    }

    /// <summary>
    // Database Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class TELCO_ID_FW
    {
    }

    /// <summary>
    // Other Prescriber Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,")]
    public class TELCO_ID_FX
    {
    }

    /// <summary>
    // Compound Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,99,")]
    public class TELCO_ID_G1
    {
    }

    /// <summary>
    // CMS Part D Defined Qualified Facility
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class TELCO_ID_G2
    {
    }

    /// <summary>
    // Measurement Dimension
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
            ",28,29,30,31,32,33,34,99,")]
    public class TELCO_ID_H2
    {
    }

    /// <summary>
    // Measurement Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
            ",")]
    public class TELCO_ID_H3
    {
    }

    /// <summary>
    // Other Payer Amount Paid Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,")]
    public class TELCO_ID_HC
    {
    }

    /// <summary>
    // Dispensing Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class TELCO_ID_HD
    {
    }

    /// <summary>
    // Basis Of Calculation-Dispensing Fee
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,99,")]
    public class TELCO_ID_HH
    {
    }

    /// <summary>
    // Basis Of Calculation-Copay
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,99,")]
    public class TELCO_ID_HJ
    {
    }

    /// <summary>
    // Basis Of Calculation-Flat Sales Tax
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,")]
    public class TELCO_ID_HK
    {
    }

    /// <summary>
    // Basis Of Calculation-Percentage Sales Tax
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,")]
    public class TELCO_ID_HM
    {
    }

    /// <summary>
    // Other Amount Paid Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,99,")]
    public class TELCO_ID_J3
    {
    }

    /// <summary>
    // Payer ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,99,")]
    public class TELCO_ID_J7
    {
    }

    /// <summary>
    // DUR Co-Agent ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,07,08,09,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29" +
            ",30,31,32,33,35,99,")]
    public class TELCO_ID_J9
    {
    }

    /// <summary>
    // Percentage Sales Tax Basis Submitted
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",02,03,")]
    public class TELCO_ID_JE
    {
    }

    /// <summary>
    // Coupon Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,99,")]
    public class TELCO_ID_KE
    {
    }

    /// <summary>
    // Patient Assignment Indicator (Direct Member Reimbursement Indicator)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class TELCO_ID_MT
    {
    }

    /// <summary>
    // Benefit Stage Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class TELCO_ID_MV
    {
    }

    /// <summary>
    // Other Payer-Patient Responsibility Amount Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,")]
    public class TELCO_ID_NP
    {
    }

    /// <summary>
    // Delay Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class TELCO_ID_NV
    {
    }

    /// <summary>
    // Request Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class TELCO_ID_PA
    {
    }

    /// <summary>
    // Basis Of Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ME,PL,PR,")]
    public class TELCO_ID_PD
    {
    }

    /// <summary>
    // Other Amount Claimed Submitted Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,99,")]
    public class TELCO_ID_H8
    {
    }

    /// <summary>
    // Authorized Representative State/Province Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_PJ
    {
    }

    /// <summary>
    // Compound Product ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,11,12,13,15,28,29,30,31,32,33,99,")]
    public class TELCO_ID_RE
    {
    }

    /// <summary>
    // Billing Entity Type Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,")]
    public class TELCO_ID_TR
    {
    }

    /// <summary>
    // Pay To Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,11,")]
    public class TELCO_ID_TS
    {
    }

    /// <summary>
    // Pay to State/Province Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_TX
    {
    }

    /// <summary>
    // Generic Equivalent Product ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,06,07,08,09,10,11,12,15,28,29,30,31,32,33,34,99,")]
    public class TELCO_ID_TZ
    {
    }

    /// <summary>
    // Pharmacy Service Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,99,")]
    public class TELCO_ID_U7
    {
    }

    /// <summary>
    // Compound Ingredient Basis of Cost Determination
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,")]
    public class TELCO_ID_UE
    {
    }

    /// <summary>
    // Additional Message Information Continuity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",+,")]
    public class TELCO_ID_UG
    {
    }

    /// <summary>
    // Additional Message Information Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,")]
    public class TELCO_ID_UH
    {
    }

    /// <summary>
    // Medicare Part D Coverage Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class TELCO_ID_UR
    {
    }

    /// <summary>
    // Other Payer-Patient Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,")]
    public class TELCO_ID_UW
    {
    }

    /// <summary>
    // Diagnosis Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,99,")]
    public class TELCO_ID_WE
    {
    }

    /// <summary>
    // Associated Prescription/Service Provider ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,99,")]
    public class TELCO_ID_XX
    {
    }

    /// <summary>
    // Associated Prescription/Service Reference Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
    public class TELCO_ID_XZ
    {
    }

    /// <summary>
    // Purchaser Address State/Province Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_Y3
    {
    }

    /// <summary>
    // Purchaser Country Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AX,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BL,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GG,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IM,IN,IO,IQ,IR,IS,IT,JE,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,ME,MF,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RS,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TL,TM,TN,TO,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,ZA,ZM,ZW,")]
    public class TELCO_ID_Y5
    {
    }

    /// <summary>
    // Service Provider State/Province Code Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_YP
    {
    }

    /// <summary>
    // Purchaser ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,99,")]
    public class TELCO_ID_YU
    {
    }

    /// <summary>
    // Purchaser ID Associated State/Province Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD" +
            ",ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NH,NJ,NL,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,P" +
            "E,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class TELCO_ID_YW
    {
    }

    /// <summary>
    // Purchaser Gender Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,")]
    public class TELCO_ID_YY
    {
    }  
}