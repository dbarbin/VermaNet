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
    
    public partial class tblWorkFlowEventDocumentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblWorkFlowEventDocumentType()
        {
            this.tblWorkflowEventAssignedDocumentTypes = new HashSet<tblWorkflowEventAssignedDocumentType>();
            this.tblWorkFlowEventConditionDocumentTypeDataSources = new HashSet<tblWorkFlowEventConditionDocumentTypeDataSource>();
            this.tblWorkFlowEventDefinitions = new HashSet<tblWorkFlowEventDefinition>();
        }
    
        public int DocumentTypeID { get; set; }
        public string DocumentDescription { get; set; }
        public string RelatedStatusTable { get; set; }
        public Nullable<int> ItemTypeEnum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkflowEventAssignedDocumentType> tblWorkflowEventAssignedDocumentTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkFlowEventConditionDocumentTypeDataSource> tblWorkFlowEventConditionDocumentTypeDataSources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkFlowEventDefinition> tblWorkFlowEventDefinitions { get; set; }
    }
}