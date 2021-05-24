using EdiFabric.Core.Model.Telco;
using EdiFabric.Templates.TelcoD0;
using System;
using System.Collections.Generic;

namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class SegmentBuilders
    {
        /// <summary>
        /// Build TransmissionHeader
        /// </summary>
        /// <returns></returns>
        public static TransmissionHeader BuildTransmissionHeader(string batchNr = "1234567", string senderId = "SENDER1", string receiverId = "RECEIVER2")
        {
            var result = new TransmissionHeader();

            result.TransmissionType_1 = "T";
            result.SenderId_2 = senderId;
            result.BatchNumber_3 = batchNr;
            result.CreationDate_4 = DateTime.Now.Date.ToString("yyyyMMdd");
            result.CreationTime_5 = DateTime.Now.TimeOfDay.ToString("hhmm");
            result.FileType_6 = "P";
            result.Version_7 = "12";
            result.ReceiverId_8 = receiverId;

            return result;
        }

        /// <summary>
        /// Build Billing Claim
        /// </summary>
        /// <returns></returns>
        public static TSB1 BuildClaim(string tranRefNumber = "123", string binNumber = "123", string processorNumber = "123", string reversalReq = "1", string billingReq = "1", string preReq = "1")
        {
            var result = new TSB1();

            //  G1 header
            result.G1 = new TransactionHeader();
            result.G1.TransactionReferenceNumber_1 = tranRefNumber;
            result.G1.BINNumber_2 = binNumber;
            result.G1.VersionReleaseNumber_3 = "D0";
            result.G1.TransactionCode_4 = "B1";
            result.G1.ProcessorControlNumber_5 = processorNumber;
            result.G1.TransactionCount_6 = "1";
            result.G1.ServiceProviderIDQualifier_7 = reversalReq;
            result.G1.ServiceProviderID_8 = billingReq;
            result.G1.DateOfService_9 = preReq;
            result.G1.SoftwareVendorCertificationID_10 = "";

            //  AM04 Loop
            result.AM04Loop = new Loop_AM04_TSB1();

            //  AM04 Segment
            result.AM04Loop.AM04 = new AM04();
            result.AM04Loop.AM04.CardholderID_C2 = "DK86342S";
            result.AM04Loop.AM04.EligibilityClarificationCode_C9 = "0";
            result.AM04Loop.AM04.PersonCode_C3 = "001";

            //  AM01 Segment
            result.AM04Loop.AM01 = new AM01();
            result.AM04Loop.AM01.DateOfBirth_C4 = "19970213";
            result.AM04Loop.AM01.PatientGenderCode_C5 = "1";
            result.AM04Loop.AM01.PatientFirstName_CA = "TAHIEM";
            result.AM04Loop.AM01.PatientLastName_CB = "HART";

            //  Repeating AM07 Loops
            result.AM07Loop = new List<Loop_AM07_TSB1>();

            //  BEGIN AM07 LOOP
            var am07Loop1 = new Loop_AM07_TSB1();

            //  AM07 Segment
            am07Loop1.AM07 = new AM07();
            am07Loop1.AM07.PrescriptionServiceReferenceNumberQualifier_EM = "1";
            am07Loop1.AM07.PrescriptionServiceReferenceNumber_D2 = "000005073530";
            am07Loop1.AM07.ProductServiceIDQualifier_E1 = "03";
            am07Loop1.AM07.ProductServiceID_D7 = "16729014912";
            am07Loop1.AM07.QuantityDispensed_E7 = "60000";
            am07Loop1.AM07.FillNumber_D3 = "00";
            am07Loop1.AM07.DaysSupply_D5 = "060";
            am07Loop1.AM07.CompoundCode_D6 = "1";
            am07Loop1.AM07.DispenseAsWritten_D8 = "0";
            am07Loop1.AM07.DatePrescriptionWritten_DE = "20151112";
            am07Loop1.AM07.NumberOfRefillsAuthorized_DF = "00";
            am07Loop1.AM07.PrescriptionOriginCode_DJ = "1";
            am07Loop1.AM07.OtherCoverageCode_C8 = "01";
            am07Loop1.AM07.ScheduledPrescriptionIDNumber_EK = "06KVYZ11";
            am07Loop1.AM07.DelayReasonCode_NV = "03";

            //  AM11 Segment
            am07Loop1.AM11 = new AM11();
            am07Loop1.AM11.IngredientCostSubmitted_D9 = "218G";
            am07Loop1.AM11.PatientPaidAmountSubmitted_DX = "0000000";
            am07Loop1.AM11.UsualAndCustomaryCharge_DQ = "253G";
            am07Loop1.AM11.GrossAmountDue_DU = "10177E";

            //  AM03 Segment
            am07Loop1.AM03 = new AM03();
            am07Loop1.AM03.PrescriberIDQualifier_EZ = "01";
            am07Loop1.AM03.PrescriberID_DB = "1023043676";

            //  AM05 Segment
            am07Loop1.AM05 = new AM05();
            am07Loop1.AM05.CoordinationOfBenefitsOtherPaymentsCount_4C = "2";
            
            //  Repeating C4C
            am07Loop1.AM05.C4C_02 = new List<C4C>();

            //  C4C 1
            var c4c1 = new C4C();
            c4c1.OtherPayerCoverageType_5C = "DATA1";
            c4c1.OtherPayerIDQualifier_6C = "DATA2";
            c4c1.OtherPayerAmountPaidCount_HB = "2";
            c4c1.CHB_07 = new List<CHB>();

            var chb1 = new CHB();
            chb1.OtherPayerAmountPaidQualifier_HC = "DATA3";
            chb1.OtherPayerAmountPaid_DV = "DATA4";
            c4c1.CHB_07.Add(chb1);

            var chb2 = new CHB();
            chb2.OtherPayerAmountPaidQualifier_HC = "DATA5";
            chb2.OtherPayerAmountPaid_DV = "DATA6";
            c4c1.CHB_07.Add(chb2);

            am07Loop1.AM05.C4C_02.Add(c4c1);

            //  C4C 2
            var c4c2 = new C4C();
            c4c2.OtherPayerCoverageType_5C = "DATA7";
            c4c2.OtherPayerIDQualifier_6C = "DATA8";
            c4c2.OtherPayerAmountPaidCount_HB = "2";
            c4c2.CHB_07 = new List<CHB>();

            var chb3 = new CHB();
            chb3.OtherPayerAmountPaidQualifier_HC = "DATA9";
            chb3.OtherPayerAmountPaid_DV = "DATA10";
            c4c2.CHB_07.Add(chb3);

            var chb4 = new CHB();
            chb4.OtherPayerAmountPaidQualifier_HC = "DATA11";
            chb4.OtherPayerAmountPaid_DV = "DATA12";
            c4c2.CHB_07.Add(chb4);

            am07Loop1.AM05.C4C_02.Add(c4c2);

            //  END AM07 LOOP
            result.AM07Loop.Add(am07Loop1);

            return result;
        }

    }
}
