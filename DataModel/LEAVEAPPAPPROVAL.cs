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
    
    public partial class LEAVEAPPAPPROVAL
    {
        public string APPLICATION_NO { get; set; }
        public string EMP_ID { get; set; }
        public Nullable<System.DateTime> APPL_DATE { get; set; }
        public string LEAVETYPE { get; set; }
        public System.DateTime DATE_FROM { get; set; }
        public System.DateTime DATE_TO { get; set; }
        public string APPROVED { get; set; }
        public Nullable<System.DateTime> APPROVED_DATE { get; set; }
        public string APPROVED_BY { get; set; }
        public Nullable<double> MSGNO { get; set; }
        public string REMARKS { get; set; }
        public string AUTHORIZEDBY { get; set; }
        public string HALF2ND { get; set; }
        public string HALF1ST { get; set; }
        public string MOD_CAN { get; set; }
        public string Attachment { get; set; }
        public string RejectReason { get; set; }
        public string ModifiedBY { get; set; }
        public string ModifyRemarks { get; set; }
        public Nullable<double> NoOfDays { get; set; }
        public string BulkApproved { get; set; }
        public string App_Year { get; set; }
        public string Subordinates { get; set; }
        public Nullable<bool> AutoInsert { get; set; }
    }
}
