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
    
    public partial class tblDashboardPanelsDefaultFieldDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDashboardPanelsDefaultFieldDefinition()
        {
            this.tblDashboardPanelsRepFieldDefinitions = new HashSet<tblDashboardPanelsRepFieldDefinition>();
        }
    
        public int DashboardPanelsDefaultFieldDefinitionsKeyID { get; set; }
        public int FKDashBoardPanels { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public string DataType { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Value { get; set; }
        public Nullable<int> Min { get; set; }
        public Nullable<int> Max { get; set; }
        public Nullable<int> FKDashboardSupportTable { get; set; }
        public string PropertyGridCategory { get; set; }
        public string SubQuery { get; set; }
        public bool ExcludeFromWHEREClause { get; set; }
        public bool Required { get; set; }
        public bool AdminFilter { get; set; }
    
        public virtual tblDashBoardPanel tblDashBoardPanel { get; set; }
        public virtual tblDashBoardPanelsFilterOperator tblDashBoardPanelsFilterOperator { get; set; }
        public virtual tblDashboardSupportTable tblDashboardSupportTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDashboardPanelsRepFieldDefinition> tblDashboardPanelsRepFieldDefinitions { get; set; }
    }
}
