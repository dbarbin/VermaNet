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
    
    public partial class tblContactGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblContactGroup()
        {
            this.tblAssignedContactGroups = new HashSet<tblAssignedContactGroup>();
        }
    
        public string ContactGroup { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public bool AllowDelete { get; set; }
        public Nullable<System.DateTime> KeepUntilDate { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAssignedContactGroup> tblAssignedContactGroups { get; set; }
    }
}
