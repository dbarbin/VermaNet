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
    
    public partial class tvw_ExchangeListView
    {
        public int ExchangeKeyID { get; set; }
        public Nullable<System.DateTime> ExchangeDate { get; set; }
        public int SONumber { get; set; }
        public int FKSOPartsUsed { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public string Disposition { get; set; }
        public string WarrantyStatus { get; set; }
        public int FKCustomerInventory { get; set; }
        public int FKCustomerInventoryAssemblyDetail { get; set; }
        public decimal RepairCost { get; set; }
        public decimal InventoryReinstatementValue { get; set; }
        public decimal InventoryReinstatementCost { get; set; }
        public string Location { get; set; }
        public string RMANumber { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<System.DateTime> DiscardDate { get; set; }
        public Nullable<System.DateTime> InventoryReturnDate { get; set; }
        public string ExchangeValueGLCode { get; set; }
        public string ExchangeCreditGLCode { get; set; }
        public string OverUnderGLCode { get; set; }
        public string Notes { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public string CustomerItemID { get; set; }
        public string CustomerItemDescription { get; set; }
        public string CustomerSerialNumber { get; set; }
        public string VendorName { get; set; }
        public Nullable<int> VendorAccountNumber { get; set; }
    }
}
