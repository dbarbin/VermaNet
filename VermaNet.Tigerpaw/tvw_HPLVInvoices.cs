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
    
    public partial class tvw_HPLVInvoices
    {
        public int ID { get; set; }
        public Nullable<int> Image { get; set; }
        public int InvoiceNumber { get; set; }
        public string Status { get; set; }
        public Nullable<bool> Paid { get; set; }
        public Nullable<decimal> TotalAmountDue { get; set; }
        public Nullable<decimal> TotalGrossSell { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string AccountName { get; set; }
        public int Repnumber { get; set; }
        public int AccountNumber { get; set; }
        public bool OnHold { get; set; }
    }
}