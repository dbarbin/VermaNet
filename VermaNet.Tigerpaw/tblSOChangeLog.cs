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
    
    public partial class tblSOChangeLog
    {
        public int SOChangeLogKeyID { get; set; }
        public int FKChangeOrderDetail { get; set; }
        public System.DateTime DateApplied { get; set; }
        public int RepMakingChange { get; set; }
        public double OldQuantity { get; set; }
        public double NewQuantity { get; set; }
        public double QuantityDelta { get; set; }
        public decimal OldSell { get; set; }
        public decimal NewSell { get; set; }
        public Nullable<decimal> SellPriceDelta { get; set; }
        public Nullable<double> TotalPriceDelta { get; set; }
        public decimal OldCost { get; set; }
        public decimal NewCost { get; set; }
        public Nullable<decimal> CostDelta { get; set; }
        public Nullable<double> TotalCostDelta { get; set; }
        public string SourceDocument { get; set; }
        public bool SOHasBeenAdjusted { get; set; }
        public string ReasonForChange { get; set; }
        public short TypeOfChange { get; set; }
        public string ItemID { get; set; }
    
        public virtual tblChangeOrderCrossReferenceDetail tblChangeOrderCrossReferenceDetail { get; set; }
    }
}