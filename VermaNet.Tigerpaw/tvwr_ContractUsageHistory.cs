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
    
    public partial class tvwr_ContractUsageHistory
    {
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public int ContractNumber { get; set; }
        public Nullable<System.DateTime> UsagePeriodStart { get; set; }
        public Nullable<System.DateTime> UsagePeriodEnd { get; set; }
        public decimal Quantity { get; set; }
        public decimal PeriodOverageBilled { get; set; }
        public string ContractAccountName { get; set; }
        public string Basis { get; set; }
        public string RecordType { get; set; }
        public Nullable<decimal> Detail_Base { get; set; }
        public Nullable<decimal> Detail_Over { get; set; }
        public string Account_Name { get; set; }
        public string Total_Label { get; set; }
        public string Contract_Basis { get; set; }
    }
}