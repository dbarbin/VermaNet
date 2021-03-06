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
    
    public partial class tblQuoteDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQuoteDetail()
        {
            this.tblQuoteAssemblyDetails = new HashSet<tblQuoteAssemblyDetail>();
        }
    
        public int QuoteDetailKeyID { get; set; }
        public int QuoteNumber { get; set; }
        public int LineNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string Type { get; set; }
        public bool AssemblyFlag { get; set; }
        public string AssemblyType { get; set; }
        public decimal ManufacturerListPrice { get; set; }
        public decimal BookPrice { get; set; }
        public int PriceLevel { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public bool Taxable { get; set; }
        public decimal TaxableAmount { get; set; }
        public bool GSTExempt { get; set; }
        public decimal GSTaxableAmount { get; set; }
        public decimal ActualUnitCost { get; set; }
        public double Quantity { get; set; }
        public double QuantityFilled { get; set; }
        public double QuantityBackOrdered { get; set; }
        public double QuantityPosted { get; set; }
        public double UnitHoursNeeded { get; set; }
        public double TotalHoursNeeded { get; set; }
        public double HoursEntered { get; set; }
        public string UnitOfMeasure { get; set; }
        public int FKInvoiceDetail { get; set; }
        public bool PrintOnInvoice { get; set; }
        public bool CommentOnly { get; set; }
        public bool Stock { get; set; }
        public bool PrintOnQuote { get; set; }
        public int VendorAccountNumber { get; set; }
        public bool UseBookPricesAndDiscounts { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public decimal ProviderTaxableAmount { get; set; }
        public bool ItemCanBeDiscounted { get; set; }
        public double QuantityAssignedToServiceOrders { get; set; }
        public bool SingleItemTaxed { get; set; }
        public Nullable<int> FKProjectPhaseKeyID { get; set; }
        public string InstallLocation { get; set; }
        public Nullable<System.DateTime> OrderByDate { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityReceived { get; set; }
        public bool UseThisCostWhenOrdering { get; set; }
        public decimal DiscountAmount { get; set; }
        public float DiscountPercent { get; set; }
        public Nullable<int> SubtotalHeader { get; set; }
        public Nullable<int> SubtotalFooter { get; set; }
        public Nullable<int> AssociatedHeader { get; set; }
        public Nullable<int> AssociatedFooter { get; set; }
        public string ApplyDiscountOff { get; set; }
        public int SubtotalIndent { get; set; }
        public string PriceAdjuster { get; set; }
        public decimal AdjustmentAmount { get; set; }
        public float AdjustmentPercent { get; set; }
        public int FKSODetailKey { get; set; }
        public decimal TotalDiscount { get; set; }
        public bool PrintSubtotalHeaderFooter { get; set; }
        public string NonStockItemType { get; set; }
        public string NonStockVendorItemNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuoteAssemblyDetail> tblQuoteAssemblyDetails { get; set; }
    }
}
