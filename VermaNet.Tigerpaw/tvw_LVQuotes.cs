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
    
    public partial class tvw_LVQuotes
    {
        public int ID { get; set; }
        public int QuoteNumber { get; set; }
        public Nullable<System.DateTime> QuoteDate { get; set; }
        public Nullable<System.DateTime> QuoteExpirationDate { get; set; }
        public decimal AmountDue { get; set; }
        public string QuoteStatus { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public Nullable<int> TaskStatusImage { get; set; }
        public Nullable<int> TaskStatus { get; set; }
        public Nullable<System.DateTime> NextDate { get; set; }
        public string QuoteDescription { get; set; }
        public string AccountName { get; set; }
        public int QuoteRepNumber { get; set; }
        public string QuoteRepName { get; set; }
        public Nullable<decimal> TotalDollarsDiscounted { get; set; }
        public bool Approved { get; set; }
        public int OpportunityKeyID { get; set; }
        public string OpportunityName { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public Nullable<int> ContactNumber { get; set; }
        public string ContactName { get; set; }
        public string Job { get; set; }
        public string Type { get; set; }
        public string QuoteSource { get; set; }
        public Nullable<int> InvoiceNumber { get; set; }
        public Nullable<int> WorkorderNumber { get; set; }
        public Nullable<int> AccountRepNumber { get; set; }
        public string AccountRepName { get; set; }
        public bool CompletelyServiceOrdered { get; set; }
        public string PaymentMethod { get; set; }
        public string AccountType { get; set; }
        public string AccountStatus { get; set; }
        public string AccountSource { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> LeadScore { get; set; }
        public int SONumber { get; set; }
        public string WorkorderStatus { get; set; }
        public bool DisplayOnPortal { get; set; }
        public Nullable<int> eAccountGroup { get; set; }
        public Nullable<int> eAccountProfile { get; set; }
        public Nullable<int> eSICCode { get; set; }
        public Nullable<int> eItemID { get; set; }
    }
}
