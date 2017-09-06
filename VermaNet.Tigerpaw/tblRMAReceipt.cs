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
    
    public partial class tblRMAReceipt
    {
        public int RMAReceiptsKeyID { get; set; }
        public int FKRMADetail { get; set; }
        public int FKRMA { get; set; }
        public string RMANumber { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<System.DateTime> ReceivedTime { get; set; }
        public string ReceivedShipMethod { get; set; }
        public int ReceivedBy { get; set; }
        public decimal RepairCost { get; set; }
        public int Quantity { get; set; }
        public string TrackingNumber { get; set; }
        public string ReceivingLocation { get; set; }
        public string ReplacementItemID { get; set; }
        public string ReplacementDescription { get; set; }
        public decimal ReplacementCost { get; set; }
        public string ReplacementComment { get; set; }
        public Nullable<System.DateTime> ReturnedToSourceDate { get; set; }
        public string ToCustomerShipMethod { get; set; }
        public string ToCustomerWaybill { get; set; }
        public string ReceivingBin { get; set; }
    
        public virtual tblRMADetail tblRMADetail { get; set; }
    }
}