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
    
    public partial class tblActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblActivity()
        {
            this.tblActivityProfiles = new HashSet<tblActivityProfile>();
            this.tblActivitySteps = new HashSet<tblActivityStep>();
            this.tblScheduledActivities = new HashSet<tblScheduledActivity>();
        }
    
        public string ActivityName { get; set; }
        public string Description { get; set; }
        public string OperatorInstructions { get; set; }
        public string MergeExtractFileName { get; set; }
        public int MergeSignedByRepType { get; set; }
        public int MergeSignedByRepNumber { get; set; }
        public string GroupToAssign { get; set; }
        public string GroupToRemove { get; set; }
        public bool ScheduleTask { get; set; }
        public string TaskType { get; set; }
        public string TaskComment { get; set; }
        public int TaskRepNumber { get; set; }
        public string TaskTime { get; set; }
        public bool AlarmTask { get; set; }
        public int PriorityNumber { get; set; }
        public string PriorityText { get; set; }
        public int DaysToSchedule { get; set; }
        public string NewAccountStatus { get; set; }
        public string NewAccountType { get; set; }
        public bool SendEMail { get; set; }
        public string EmailText { get; set; }
        public bool IgnoreDoNotEmailFlag { get; set; }
        public string EmailLinkMessageName { get; set; }
        public string EmailAttachment { get; set; }
        public string EmailSubject { get; set; }
        public int EmailFromRepType { get; set; }
        public int EmailFromRepNumber { get; set; }
        public bool ProcessWhenScheduled { get; set; }
        public int EmployeeResponsible { get; set; }
        public bool ManualActivityIndicator { get; set; }
        public int FKLiteraturePackage { get; set; }
        public string TaskAction { get; set; }
        public int ActivityID { get; set; }
    
        public virtual tblAccountStatus tblAccountStatus { get; set; }
        public virtual tblAccountType tblAccountType { get; set; }
        public virtual tblEmailMessage tblEmailMessage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblActivityProfile> tblActivityProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblActivityStep> tblActivitySteps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblScheduledActivity> tblScheduledActivities { get; set; }
    }
}