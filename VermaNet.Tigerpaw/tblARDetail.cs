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
    
    public partial class tblARDetail
    {
        public int ARDetailKeyID { get; set; }
        public int FKARHeader { get; set; }
        public decimal Amount { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public int TaxType { get; set; }
        public string SalesTaxDistrict { get; set; }
        public float SalesTaxRate { get; set; }
        public float Quantity { get; set; }
        public string Account { get; set; }
        public string Department { get; set; }
        public int BatchNumber { get; set; }
        public decimal ActualUnitCost { get; set; }
        public decimal CostOfSalesAmount { get; set; }
        public string CostDebitAccount { get; set; }
        public string CostDebitDepartment { get; set; }
        public string CostCreditAccount { get; set; }
        public string CostCreditDepartment { get; set; }
        public bool PayCommission { get; set; }
        public string AccountingLinkSalesCode { get; set; }
        public string ItemCategory { get; set; }
        public string IncomeGLCode { get; set; }
        public string CostGLCode { get; set; }
        public string DistributionType { get; set; }
        public string SalesTaxVendor { get; set; }
        public decimal TaxableAmount { get; set; }
    
        public virtual tblARHeader tblARHeader { get; set; }
    }
}
