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
    
    public partial class tblCustomFieldAppliesTo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomFieldAppliesTo()
        {
            this.tblCustomFieldCategories = new HashSet<tblCustomFieldCategory>();
            this.tblViewSourceTables = new HashSet<tblViewSourceTable>();
        }
    
        public int AppliesToID { get; set; }
        public string AppliesToName { get; set; }
        public string ReportHeader { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomFieldCategory> tblCustomFieldCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblViewSourceTable> tblViewSourceTables { get; set; }
    }
}
