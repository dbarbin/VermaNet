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
    
    public partial class tvw_TaxableAndGSTaxableCreditMemoAssemblyDetailTotals
    {
        public int CreditMemoNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public int FKCreditMemoDetail { get; set; }
        public Nullable<decimal> Non_taxable_Assembly_Total { get; set; }
        public Nullable<decimal> PST_Taxable_Assembly_Total { get; set; }
        public Nullable<decimal> GS_Taxable_Assembly_Total { get; set; }
        public Nullable<decimal> Fully_Taxable_Assembly_Total { get; set; }
        public string IncomeGLCode { get; set; }
        public decimal UnitCreditAmount { get; set; }
        public double Quantity { get; set; }
        public int CentralBillingCreditMemosKeyID { get; set; }
    }
}