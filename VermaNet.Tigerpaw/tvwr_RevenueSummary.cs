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
    
    public partial class tvwr_RevenueSummary
    {
        public int SortNumber { get; set; }
        public System.DateTime SortDate { get; set; }
        public int SortType { get; set; }
        public string TYPE { get; set; }
        public int DocumentNumber { get; set; }
        public string Account_Name { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> Status_Date { get; set; }
        public Nullable<decimal> Gross_Amount { get; set; }
        public Nullable<decimal> Discount_Amount { get; set; }
        public Nullable<decimal> Freight_Amount { get; set; }
        public decimal Restocking { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
        public int OriginalInvoiceNumber { get; set; }
        public string Comments { get; set; }
    }
}
