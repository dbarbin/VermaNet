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
    
    public partial class tblsysMobileDefault
    {
        public int ID { get; set; }
        public bool Allow24HourLogin { get; set; }
        public bool AllowTravelEntry { get; set; }
        public bool CreateTravelExpense { get; set; }
        public bool AllowMileage { get; set; }
        public bool RequireOdometer { get; set; }
        public bool Reimbursable { get; set; }
        public bool Billable { get; set; }
        public Nullable<int> FKExpenseType { get; set; }
        public Nullable<int> FKPaymentType { get; set; }
        public bool CreateTravelTimeLog { get; set; }
        public string TravelLogReason { get; set; }
        public string TravelSOStatus { get; set; }
        public bool TravelNotifyDispatch { get; set; }
        public int CopyLogComments { get; set; }
        public short CopyCommentPrependInfo { get; set; }
        public string WorkLogReason { get; set; }
        public string WorkStartSOStatus { get; set; }
        public bool WorkStartNotifyDispatch { get; set; }
        public string CompleteWorkSOStatus { get; set; }
        public bool CompleteWorkNotifyDispatch { get; set; }
        public bool CompleteTask { get; set; }
        public bool DeleteTask { get; set; }
        public bool CreateJournalForTasks { get; set; }
        public string WebServiceURL { get; set; }
        public string HostHeader { get; set; }
        public string DateFormat { get; set; }
        public string TimeFormat { get; set; }
        public string Culture { get; set; }
        public bool ForceTravelTimeLogs { get; set; }
        public string OpportunityWonStatus { get; set; }
        public string OpportunityLostStatus { get; set; }
    
        public virtual tblExpensePaymentType tblExpensePaymentType { get; set; }
        public virtual tblExpenseType tblExpenseType { get; set; }
    }
}