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
    
    public partial class tvw_Portal_Opportunities_Employee
    {
        public int OpportunityKeyID { get; set; }
        public int AccountNumber { get; set; }
        public string OpportunityName { get; set; }
        public int OpportunityOwner { get; set; }
        public string OpportunityNotes { get; set; }
        public string OpportunityType { get; set; }
        public string OpportunityStatus { get; set; }
        public string OpportunitySource { get; set; }
        public string NextStep { get; set; }
        public int FKOpportunityStages { get; set; }
        public Nullable<int> ProbabilityPercent { get; set; }
        public Nullable<System.DateTime> EstimatedCloseDate { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public System.DateTime LastModified { get; set; }
        public decimal ExpectedAmount { get; set; }
        public decimal BestCaseAmount { get; set; }
        public decimal WorstCaseAmount { get; set; }
        public Nullable<int> ContactNumber { get; set; }
        public string Competition { get; set; }
        public int LastModifiedByRep { get; set; }
        public string CloseReason { get; set; }
        public string Strategy { get; set; }
        public string AccountName { get; set; }
        public string RepName { get; set; }
        public string OpportunityStageDescription { get; set; }
        public int StateOfOpportunity { get; set; }
        public Nullable<int> QuoteNumber { get; set; }
        public Nullable<int> LeadScore { get; set; }
    }
}
