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
    
    public partial class tvwr_ProjectPhasesWithTask
    {
        public int ProjectKeyID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectPhase { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public string TaskComment { get; set; }
        public Nullable<int> TaskKeyID { get; set; }
        public int ProjectPhaseKeyID { get; set; }
        public string TaskType { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> EstimatedCompletionDate { get; set; }
        public string Priority { get; set; }
        public string ProjectDescription { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ExpectedCompletionDate { get; set; }
        public Nullable<System.DateTime> ExpectedStartDate { get; set; }
        public Nullable<System.DateTime> ActualCompletionDate { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public int OrdinalPosition { get; set; }
    }
}
