//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class LEAVEMASTER
    {
        public string LEAVE_ID { get; set; }
        public string LEAVE_DESCRIPTION { get; set; }
        public string ENCASHABLE { get; set; }
        public string CARRY_FORWARD { get; set; }
        public string YEARS { get; set; }
        public string DAYS { get; set; }
        public Nullable<double> DAYS_YEARS { get; set; }
        public string ACC_BEFORE_PERIOD { get; set; }
        public string ACC_AFTER_PERIOD { get; set; }
        public string YEARLY { get; set; }
        public string MONTHLY { get; set; }
        public double NO_OF_DAYS { get; set; }
        public string APPTO { get; set; }
        public string APPLICABLETO { get; set; }
        public string APPLICABLE_TO { get; set; }
        public string ELIGIBILITY { get; set; }
        public Nullable<double> MIN_BAL_DAYS { get; set; }
        public Nullable<double> MAX_ENCASH_DAYS { get; set; }
        public Nullable<double> MIN_NO_OF_DAYS { get; set; }
        public Nullable<double> MAX_NO_OF_DAYS { get; set; }
        public System.DateTime EFFECTDATE { get; set; }
        public Nullable<double> MAX_LEAVE_MON { get; set; }
        public Nullable<double> MAX_LEAVE_TIME { get; set; }
        public string NEGA_LEAVE_ACCRUED { get; set; }
        public Nullable<double> MIN_ENCDAYS_ACCRUED { get; set; }
        public Nullable<double> LTID { get; set; }
        public string PAIDLEAVE { get; set; }
        public string FORMULA { get; set; }
        public string ACC_ELIGIBILITY { get; set; }
        public string ACC_CAL { get; set; }
        public Nullable<double> ELIGIBILITY_DAYS { get; set; }
        public Nullable<double> ACC_DAYS { get; set; }
        public Nullable<double> ROUNDDAYS { get; set; }
        public string PERDAY { get; set; }
        public string Embed { get; set; }
        public string AutoEncash { get; set; }
        public Nullable<decimal> accrualLimit { get; set; }
        public string Quarterly { get; set; }
        public string Anniversary { get; set; }
        public Nullable<double> MAX_LEAVEAccept_MONTH { get; set; }
        public Nullable<bool> UploadDocument { get; set; }
        public Nullable<int> DocumentReqDays { get; set; }
        public Nullable<int> CompOffExpDays { get; set; }
        public string CompOffUtiliseApproveFlag { get; set; }
        public Nullable<bool> IsCompOffType { get; set; }
        public Nullable<double> MinLeavesPerRequest { get; set; }
        public Nullable<double> MaxLeavesPerRequest { get; set; }
        public Nullable<double> MaxLeavesPerYear { get; set; }
        public string LeavesCombinationAfter { get; set; }
        public Nullable<double> DaysGapAfterLeave { get; set; }
        public string Before15 { get; set; }
        public string After15 { get; set; }
        public string HalfYearly { get; set; }
        public string IsMailReqForSecondManager { get; set; }
        public string EMBED_PREFIX { get; set; }
        public string EMBED_SUFFIX { get; set; }
    }
}