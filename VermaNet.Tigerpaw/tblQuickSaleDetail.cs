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
    
    public partial class tblQuickSaleDetail
    {
        public int QuickSaleDetailKeyID { get; set; }
        public int QuickSaleNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string Type { get; set; }
        public string AssemblyType { get; set; }
        public Nullable<int> PriceLevel { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public bool Taxable { get; set; }
        public decimal TaxableAmount { get; set; }
        public bool GSTExempt { get; set; }
        public decimal GSTaxableAmount { get; set; }
        public string UnitOfMeasure { get; set; }
        public string CostGLCode { get; set; }
        public string IncomeGLCode { get; set; }
        public bool Serialized { get; set; }
        public string Location { get; set; }
        public bool PrintOnInvoice { get; set; }
        public double Quantity { get; set; }
        public double QuantityFilled { get; set; }
        public bool PostToCustomerInventory { get; set; }
        public bool CommentOnly { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public decimal ProviderTaxableAmount { get; set; }
        public bool SingleItemTaxed { get; set; }
        public bool UseBookPricesAndDiscounts { get; set; }
        public string UPC { get; set; }
        public string SerialNumber { get; set; }
        public bool ItemCanBeDiscounted { get; set; }
    }
}