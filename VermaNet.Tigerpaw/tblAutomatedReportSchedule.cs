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
    
    public partial class tblAutomatedReportSchedule
    {
        public int AutomatedReportScheduleID { get; set; }
        public int AutomatedReportID { get; set; }
        public System.DateTime RunDate { get; set; }
        public System.DateTime RunTime { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> ReportStartDate { get; set; }
        public Nullable<System.DateTime> ReportEndDate { get; set; }
        public string ReportFileName { get; set; }
    
        public virtual tblAutomatedReport tblAutomatedReport { get; set; }
    }
}
