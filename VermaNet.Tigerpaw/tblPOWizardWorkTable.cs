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
    
    public partial class tblPOWizardWorkTable
    {
        public int POWizardWorkTableKeyID { get; set; }
        public int RepNumber { get; set; }
        public int OrderNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public double QuantityToOrder { get; set; }
        public string ItemType { get; set; }
        public string AssemblyType { get; set; }
        public int OrderProjectPhaseKey { get; set; }
        public double QuantityNeeded { get; set; }
        public Nullable<System.DateTime> OrderByDate { get; set; }
        public string DetailProjectPhase { get; set; }
        public int DetailKeyID { get; set; }
        public string AssignedVendor { get; set; }
        public int AssignedVendorAccountNumber { get; set; }
        public bool UseOrderCost { get; set; }
        public string OrderType { get; set; }
        public Nullable<int> DetailProjectPhaseKey { get; set; }
        public Nullable<int> AssemblyDetailKeyID { get; set; }
        public Nullable<int> PONumber { get; set; }
        public Nullable<int> PODetailKeyID { get; set; }
        public decimal CostToUse { get; set; }
        public decimal PBBaseCost { get; set; }
        public decimal PBAverageCost { get; set; }
        public decimal PBLatestCost { get; set; }
        public decimal PBRepairCost { get; set; }
        public bool IsRepair { get; set; }
        public Nullable<int> ProjectKeyID { get; set; }
        public bool Stock { get; set; }
    }
}
