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
    
    public partial class tvwr_MSPInvoiceComparsionHeader
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public decimal InvoiceTotalGrossSell { get; set; }
        public int InvoiceOrder { get; set; }
        public string InvoiceDetailItemID { get; set; }
        public double InvoiceDetailQuantity { get; set; }
        public int MSPAgreementNumber { get; set; }
    }
}