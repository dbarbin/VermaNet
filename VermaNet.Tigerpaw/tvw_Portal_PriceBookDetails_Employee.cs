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
    
    public partial class tvw_Portal_PriceBookDetails_Employee
    {
        public int QuantityOnHand { get; set; }
        public int QuantityReserved { get; set; }
        public int QuantityOnOrder { get; set; }
        public int QuantityNeededtoFillOrders { get; set; }
        public string Comments { get; set; }
        public string Features { get; set; }
        public string TaxList { get; set; }
        public Nullable<int> Available { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public bool PrintOnInvoice { get; set; }
        public decimal ManufacturerListPrice { get; set; }
        public bool PrintOnQuote { get; set; }
        public decimal BaseCost { get; set; }
    }
}