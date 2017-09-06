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
    
    public partial class tblSOTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSOTemplate()
        {
            this.tblRecurringOrderTemplates = new HashSet<tblRecurringOrderTemplate>();
            this.tblSOTemplateActionPlanDetails = new HashSet<tblSOTemplateActionPlanDetail>();
            this.tblSOTemplateLogs = new HashSet<tblSOTemplateLog>();
            this.tblSOTemplateParts = new HashSet<tblSOTemplatePart>();
        }
    
        public int SOTemplatesKeyID { get; set; }
        public string SOTemplateName { get; set; }
        public string BriefDescription { get; set; }
        public Nullable<int> FKDispatchBoardKeyID { get; set; }
        public int TechAssigned { get; set; }
        public string AssociatedTechsGroup { get; set; }
        public string SOStatus { get; set; }
        public string SOType { get; set; }
        public string SOPriority { get; set; }
        public int EstimatedHours { get; set; }
        public int EstimatedMinutes { get; set; }
        public string WorkRequested { get; set; }
        public string WorkPerformed { get; set; }
        public string InternalComments { get; set; }
        public int FKPriceLevel { get; set; }
        public bool UseDefaultContract { get; set; }
        public string ContactProfile { get; set; }
        public bool UseContractPriority { get; set; }
    
        public virtual tblDispatchBoard tblDispatchBoard { get; set; }
        public virtual tblPriority tblPriority { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRecurringOrderTemplate> tblRecurringOrderTemplates { get; set; }
        public virtual tblSOStatus tblSOStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSOTemplateActionPlanDetail> tblSOTemplateActionPlanDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSOTemplateLog> tblSOTemplateLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSOTemplatePart> tblSOTemplateParts { get; set; }
        public virtual tblSOType tblSOType { get; set; }
    }
}