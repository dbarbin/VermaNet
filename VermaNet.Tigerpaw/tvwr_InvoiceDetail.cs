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
    
    public partial class tvwr_InvoiceDetail
    {
        public Nullable<int> AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public decimal Deposit { get; set; }
        public decimal GSTax { get; set; }
        public int InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public int SONumber { get; set; }
        public string Status { get; set; }
        public decimal TotalDollarsDiscounted { get; set; }
        public decimal Tax { get; set; }
        public decimal TradeIn { get; set; }
        public int WorkOrderNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
        public string UnitOfMeasure { get; set; }
        public Nullable<decimal> TotalSellingPrice { get; set; }
        public string PartNumber { get; set; }
        public string GeneralResolutions { get; set; }
        public bool HideGSTaxRelatedInformation { get; set; }
        public string PrintItemorPartNum { get; set; }
        public string ARCustomerNumber { get; set; }
        public Nullable<decimal> Deductions { get; set; }
        public decimal TotalAmountDue { get; set; }
        public bool GSTIsTaxable { get; set; }
        public bool FreightTaxable { get; set; }
        public decimal Freight { get; set; }
        public decimal ProviderTax { get; set; }
        public float ProviderTaxRate { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Item_or_Part { get; set; }
    }
}
