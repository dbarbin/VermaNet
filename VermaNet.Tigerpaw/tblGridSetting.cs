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
    
    public partial class tblGridSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGridSetting()
        {
            this.tblFilterFields = new HashSet<tblFilterField>();
            this.tblGridColumns = new HashSet<tblGridColumn>();
        }
    
        public int GridSettingsKeyID { get; set; }
        public int RepNumber { get; set; }
        public string FormName { get; set; }
        public string GridName { get; set; }
        public string UserDescription { get; set; }
        public string DataSource { get; set; }
        public string PreviousRowID { get; set; }
        public string CurrentRowID { get; set; }
        public string NextRowID { get; set; }
        public int CurrentRowNumber { get; set; }
        public int RowHeight { get; set; }
        public bool MostRecentUsed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFilterField> tblFilterFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGridColumn> tblGridColumns { get; set; }
        public virtual tblRep tblRep { get; set; }
    }
}