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
    
    public partial class tblCustomFoldersFolder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomFoldersFolder()
        {
            this.tblCustomFoldersNotes = new HashSet<tblCustomFoldersNote>();
        }
    
        public string Category { get; set; }
        public string Folder { get; set; }
        public int CategoryFolderKeyID { get; set; }
    
        public virtual tblCustomFoldersCategory tblCustomFoldersCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomFoldersNote> tblCustomFoldersNotes { get; set; }
    }
}
