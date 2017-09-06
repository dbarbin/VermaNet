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
    
    public partial class tvwr_PriceBookPurchasing
    {
        public string AccountName { get; set; }
        public string VendorItemNumber { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> LeadDays { get; set; }
        public string CaseItemID { get; set; }
        public string CaseDescription { get; set; }
        public string CaseUnitOfMeasure { get; set; }
        public double CaseQuantity { get; set; }
        public decimal CaseCost { get; set; }
        public string ReceivingLocation { get; set; }
        public Nullable<System.DateTime> LastReceivedDate { get; set; }
        public bool UpdateBaseCostAndSellPrices { get; set; }
        public bool PrintSingleReceiptLabels { get; set; }
        public int QuantityNeededtoFillOrders { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public float ReorderQuantity { get; set; }
        public bool UpdateVendorCost { get; set; }
        public string ItemID { get; set; }
    }
}