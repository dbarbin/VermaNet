//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VermaNet.Tigerpaw
{
    using System;
    using System.Collections.Generic;
    
    public partial class tvw_TokenData_TimeEntry
    {
        public int TimeSlipKeyID { get; set; }
        public int SOLogKeyID { get; set; }
        public string LogType { get; set; }
        public int TechNumber { get; set; }
        public string TechName { get; set; }
        public int SONumber { get; set; }
        public string SOBriefDescription { get; set; }
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int ContractNumberOnSO { get; set; }
        public int AcceptedOrRejectedByNumber { get; set; }
        public string AcceptedOrRejectedByName { get; set; }
        public string TimeEntryReason { get; set; }
        public string TimeEntryWorkPerformed { get; set; }
        public string RejectedReason { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string LogTime { get; set; }
        public string ActualTime { get; set; }
        public int DeductHours { get; set; }
        public short DeductMinutes { get; set; }
        public int UtilizationHours { get; set; }
        public short UtilizationMinutes { get; set; }
        public string InternalComments { get; set; }
        public string TimeEntrySource { get; set; }
    }
}