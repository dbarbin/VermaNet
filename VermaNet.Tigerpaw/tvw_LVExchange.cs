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
    
    public partial class tvw_LVExchange
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> ExchangeDate { get; set; }
        public int SONumber { get; set; }
        public string Status { get; set; }
        public string CustomerItemID { get; set; }
        public string CustomerItemDescription { get; set; }
        public string CustomerSerialNumber { get; set; }
        public string ExchangeItemID { get; set; }
        public string ExchangeDescription { get; set; }
        public string ExchangeSerialNumber { get; set; }
        public string Disposition { get; set; }
        public string VendorName { get; set; }
        public Nullable<int> VendorAccountNumber { get; set; }
        public string Location { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public int FKCustomerInventory { get; set; }
        public int FKSOPartsUsed { get; set; }
        public Nullable<int> PBCustomerItemID { get; set; }
        public Nullable<int> PBExchangeItemID { get; set; }
    }
}
