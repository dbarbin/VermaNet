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
    
    public partial class tvwr_OpportunityStageChange
    {
        public int OpportunityKeyID { get; set; }
        public int AccountNumber { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityStatus { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string CloseReason { get; set; }
        public string AccountName { get; set; }
        public string ContactName { get; set; }
        public Nullable<System.DateTime> StageChangedDate { get; set; }
        public string StageChangedTo { get; set; }
        public Nullable<System.DateTime> DateLeftThisStage { get; set; }
    }
}
