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
    
    public partial class tvwr_SalesEstimateToActual
    {
        public int OpportunityKeyID { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public decimal ExpectedAmount { get; set; }
        public string RepName { get; set; }
        public int StateOfOpportunity { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<decimal> QuoteTotalNetSell { get; set; }
        public Nullable<decimal> InvoiceTotalNetSell { get; set; }
    }
}
