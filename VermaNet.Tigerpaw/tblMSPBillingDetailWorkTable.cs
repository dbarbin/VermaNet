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
    
    public partial class tblMSPBillingDetailWorkTable
    {
        public int MSPBillingDetailWorkTableKeyID { get; set; }
        public int RepNumber { get; set; }
        public int AgreementNumber { get; set; }
        public string SpecialItemID { get; set; }
        public decimal SellingPrice { get; set; }
        public double Quantity { get; set; }
        public string IncomeGLCode { get; set; }
        public string CostGlCode { get; set; }
        public decimal BaseCost { get; set; }
        public string ItemDescription { get; set; }
        public int ItemKeyID { get; set; }
        public bool PrintWhenQtyZero { get; set; }
        public bool DeleteAfterInvoice { get; set; }
    }
}