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
    
    public partial class tblPOPostingJournal
    {
        public int ID { get; set; }
        public int FKPODetail { get; set; }
        public int BatchNumber { get; set; }
        public int PoNumber { get; set; }
        public string ItemID { get; set; }
        public double Quantity { get; set; }
        public bool RepairFlag { get; set; }
        public decimal TotalReceivedCost { get; set; }
        public decimal TotalAddedCost { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal TotalWriteoff { get; set; }
        public bool PrintedFlag { get; set; }
        public Nullable<System.DateTime> DatePosted { get; set; }
        public decimal OldLatestCost { get; set; }
        public decimal OldAverageCost { get; set; }
    
        public virtual tblPODetail tblPODetail { get; set; }
    }
}