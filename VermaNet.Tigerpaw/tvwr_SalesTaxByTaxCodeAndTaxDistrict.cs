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
    
    public partial class tvwr_SalesTaxByTaxCodeAndTaxDistrict
    {
        public int DocumentNumber { get; set; }
        public string DocumentType { get; set; }
        public decimal Tax { get; set; }
        public decimal GSTax { get; set; }
        public decimal ProviderTax { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public string SalesTaxDistrict { get; set; }
        public string SalesTaxCode { get; set; }
        public Nullable<decimal> TaxableAmount { get; set; }
        public Nullable<decimal> SalesTax { get; set; }
        public Nullable<System.DateTime> PostingDate { get; set; }
        public Nullable<System.DateTime> ARPostedDate { get; set; }
        public float TaxRate { get; set; }
        public Nullable<decimal> DistrictTaxableAmount { get; set; }
        public Nullable<decimal> DistrictNonTaxableAmount { get; set; }
    }
}