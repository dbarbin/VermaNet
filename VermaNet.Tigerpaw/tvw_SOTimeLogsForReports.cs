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
    
    public partial class tvw_SOTimeLogsForReports
    {
        public Nullable<decimal> StandardRate { get; set; }
        public string RepName { get; set; }
        public int SONumber { get; set; }
        public string TimeLogReason { get; set; }
        public string LogComment { get; set; }
        public Nullable<int> LogHours { get; set; }
        public Nullable<int> LogMinutes { get; set; }
        public Nullable<bool> Chargable { get; set; }
        public Nullable<bool> Billable { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<int> SOLogKeyID { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
    }
}