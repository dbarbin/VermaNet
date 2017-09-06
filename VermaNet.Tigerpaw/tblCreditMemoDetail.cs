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
    
    public partial class tblCreditMemoDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCreditMemoDetail()
        {
            this.tblCreditMemoAssemblyDetails = new HashSet<tblCreditMemoAssemblyDetail>();
        }
    
        public int CreditMemoDetailKeyID { get; set; }
        public int CreditMemoNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string InventoryType { get; set; }
        public double Quantity { get; set; }
        public int PriceLevel { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal UnitCreditAmount { get; set; }
        public decimal TotalCreditAmount { get; set; }
        public bool GSTExempt { get; set; }
        public decimal GSTaxableAmount { get; set; }
        public bool Taxable { get; set; }
        public decimal TaxableAmount { get; set; }
        public bool Serialized { get; set; }
        public string CostGLCode { get; set; }
        public string IncomeGLCode { get; set; }
        public decimal ActualUnitCost { get; set; }
        public decimal TotalActualCost { get; set; }
        public int ContractNumber { get; set; }
        public int FKInvoiceDetail { get; set; }
        public int FKInvoiceAssemblyDetail { get; set; }
        public int FKCustomerInventory { get; set; }
        public int FKCustomerInventoryAssemblyDetail { get; set; }
        public Nullable<System.DateTime> DateMerchandiseReturned { get; set; }
        public string ReceivedVia { get; set; }
        public Nullable<int> ReceivedBy { get; set; }
        public bool CommentOnly { get; set; }
        public decimal UnitCostOnSourceDocument { get; set; }
        public decimal TotalCostOnSourceDocument { get; set; }
        public bool PrintOnInvoice { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public decimal ProviderTaxableAmount { get; set; }
        public bool SingleItemTaxed { get; set; }
        public float DiscountOnSourceDocument { get; set; }
        public bool ItemCanBeDiscounted { get; set; }
        public float ActualSourceDiscount { get; set; }
        public int CentralBillingCreditMemosKeyID { get; set; }
        public int AccountNumber { get; set; }
        public int SourceDocumentNumber { get; set; }
        public short SourceDocumentType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCreditMemoAssemblyDetail> tblCreditMemoAssemblyDetails { get; set; }
        public virtual tblCreditMemo tblCreditMemo { get; set; }
    }
}