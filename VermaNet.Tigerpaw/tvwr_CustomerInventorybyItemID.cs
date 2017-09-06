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
    
    public partial class tvwr_CustomerInventorybyItemID
    {
        public int AccountNumber { get; set; }
        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress1 { get; set; }
        public string AccountAddress2 { get; set; }
        public string AccountCity { get; set; }
        public string AccountState { get; set; }
        public string AccountPostalCode { get; set; }
        public int CustomerInventoryKeyID { get; set; }
        public string CustomerInventoryItemID { get; set; }
        public string CustomerInventoryItemDescription { get; set; }
        public string CustomerInventorySerialNumber { get; set; }
        public decimal CustomerInventoryPurchasePrice { get; set; }
        public bool CustomerInventoryPurchasedFromUs { get; set; }
        public int CustomerInventoryCurrMeterReading { get; set; }
        public int CustomerInventoryOrigMeterReading { get; set; }
        public string CustomerInventoryLocation { get; set; }
        public int CustomerInventoryContractNumber { get; set; }
        public string CustomerInventoryContractDescription { get; set; }
        public int CustomerInventoryInvoiceNumber { get; set; }
        public string CustomerInventoryContactName { get; set; }
        public string CustomerInventoryContactPhone { get; set; }
        public Nullable<System.DateTime> CustomerInventoryDatePurchased { get; set; }
        public Nullable<System.DateTime> CustomerInventoryWarrantyExpiry { get; set; }
        public Nullable<System.DateTime> CustomerInventoryLastPMDate { get; set; }
        public Nullable<System.DateTime> CustomerInventoryNextPMDate { get; set; }
        public Nullable<System.DateTime> CustomerInventoryMFGWarrantyExpiry { get; set; }
        public Nullable<System.DateTime> CustomerInventoryDatePurchasedFromVendor { get; set; }
        public string CustomerInventoryStatus { get; set; }
        public string CustomerInventoryStatusComment { get; set; }
        public bool CustomerInventoryAllowExchange { get; set; }
        public decimal CustomerInventoryYearlyMaintPrice { get; set; }
        public Nullable<System.DateTime> CustomerInventoryStatusDate { get; set; }
        public bool CustomerInventoryAssemblyFlag { get; set; }
        public string CustomerInventoryVendorName { get; set; }
        public string CustomerInventoryItemType { get; set; }
        public string CustomerInventoryComments { get; set; }
        public double CustomerInventoryQuantity { get; set; }
        public string CustomerInventoryVendorInvoiceNumber { get; set; }
        public string AssemblyItemID { get; set; }
        public string AssemblyItemDescription { get; set; }
        public string AssemblySerialNumber { get; set; }
        public string AssemblyStatusComments { get; set; }
        public string AssemblyStatus { get; set; }
        public Nullable<System.DateTime> AssemblyDatePurchased { get; set; }
        public Nullable<System.DateTime> AssemblyWarantyExpiry { get; set; }
        public Nullable<decimal> AssemblyPurchasePrice { get; set; }
        public Nullable<bool> AssemblyPurchasedFromUs { get; set; }
        public Nullable<System.DateTime> AssemblyStatusDate { get; set; }
        public Nullable<bool> AssemblyAllowExchange { get; set; }
        public Nullable<System.DateTime> AssemblyMFGWarrantyExpiry { get; set; }
        public string AssemblyVendorName { get; set; }
        public Nullable<double> AssemblyQuantity { get; set; }
    }
}