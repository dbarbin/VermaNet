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
    
    public partial class tvwr_CreditMemoUsingEstimatedCost
    {
        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public string ARCustomerNumber { get; set; }
        public int CreditMemoNumber { get; set; }
        public string CreditType { get; set; }
        public System.DateTime DateCreated { get; set; }
        public decimal DiscountDollars { get; set; }
        public decimal FreightCredit { get; set; }
        public decimal GrossCreditAmount { get; set; }
        public decimal GSTax { get; set; }
        public decimal NetCreditAmount { get; set; }
        public int OriginalInvoiceNumber { get; set; }
        public string RepName { get; set; }
        public decimal RestockingAmount { get; set; }
        public decimal SalesTax { get; set; }
        public string Status { get; set; }
        public decimal TradeInApplied { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal TotalCreditCost { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public float Commission { get; set; }
        public Nullable<float> CommissiononNet { get; set; }
        public Nullable<float> CommissiononProfit { get; set; }
        public decimal EstimatedCostOnSourceDocument { get; set; }
        public Nullable<int> ContractNumber { get; set; }
        public int RepNumber { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
    }
}
