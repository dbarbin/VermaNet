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
    
    public partial class tvw_Portal_WorkFlow_Employee
    {
        public Nullable<int> EventLogID { get; set; }
        public Nullable<int> RepNumber { get; set; }
        public string ActionRequired { get; set; }
        public Nullable<System.DateTime> DateRead { get; set; }
        public Nullable<bool> Completed { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public Nullable<bool> Acknowledged { get; set; }
        public Nullable<System.DateTime> AcknowledgedDate { get; set; }
        public string EventName { get; set; }
        public string WorkFlowDepartment { get; set; }
        public int WorkFlowEventDefinitionsKeyID { get; set; }
        public bool FlagLogsAsCompletedWhenViewed { get; set; }
        public int WorkFlowEventLogsKeyID { get; set; }
        public int FKWorkFlowEventDefinitions { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public int DocumentType { get; set; }
        public int RepCausingEvent { get; set; }
        public int AccountNumber { get; set; }
        public int ContactNumber { get; set; }
        public int FKTasks { get; set; }
        public int QuoteNumber { get; set; }
        public string SONumber { get; set; }
        public int WorkOrderNumber { get; set; }
        public int PONumber { get; set; }
        public int InvoiceNumber { get; set; }
        public int CreditMemoNumber { get; set; }
        public int DebitMemoNumber { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public Nullable<System.DateTime> DatePosted { get; set; }
        public string Details { get; set; }
        public int OldAccountRep { get; set; }
        public int FKOpportunityKeyID { get; set; }
        public int ProjectKeyID { get; set; }
        public string EventType { get; set; }
        public string RepName { get; set; }
        public string ContactName { get; set; }
        public string ContactPrimaryPhoneNumber { get; set; }
        public string ContactPrimaryEmailAddress { get; set; }
        public string AccountPrimaryPhoneNumber { get; set; }
        public string AccountPrimaryEmailAddress { get; set; }
        public string AccountName { get; set; }
    }
}
