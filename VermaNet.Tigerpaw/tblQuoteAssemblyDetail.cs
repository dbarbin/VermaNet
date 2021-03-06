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
    
    public partial class tblQuoteAssemblyDetail
    {
        public int QuoteAssemblyDetailKeyID { get; set; }
        public int FKQuoteDetail { get; set; }
        public int QuoteNumber { get; set; }
        public string AssemblyItemID { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string Type { get; set; }
        public double EachQuantity { get; set; }
        public double Quantity { get; set; }
        public double QuantityFilled { get; set; }
        public double QuantityPosted { get; set; }
        public decimal ManufacturerListPrice { get; set; }
        public decimal BookPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public bool Taxable { get; set; }
        public decimal TaxableAmount { get; set; }
        public bool GSTExempt { get; set; }
        public decimal GSTaxableAmount { get; set; }
        public int PriceLevel { get; set; }
        public float UnitHoursNeeded { get; set; }
        public double TotalHoursNeeded { get; set; }
        public double HoursEntered { get; set; }
        public string UnitOfMeasure { get; set; }
        public int CancelledBy { get; set; }
        public int FKInvoiceAssemblyDetail { get; set; }
        public decimal ActualUnitCost { get; set; }
        public bool PrintOnQuote { get; set; }
        public bool PrintOnInvoice { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public decimal ProviderTaxableAmount { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityReceived { get; set; }
        public bool UseThisCostWhenOrdering { get; set; }
        public Nullable<System.DateTime> OrderByDate { get; set; }
        public int FKSOAssemblyDetailKey { get; set; }
    
        public virtual tblQuoteDetail tblQuoteDetail { get; set; }
    }
}
