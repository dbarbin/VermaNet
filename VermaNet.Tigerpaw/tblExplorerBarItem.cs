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
    
    public partial class tblExplorerBarItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblExplorerBarItem()
        {
            this.tblExplorerBarViewDetails = new HashSet<tblExplorerBarViewDetail>();
        }
    
        public int ExplorerBarKeyID { get; set; }
        public string LinkCaption { get; set; }
        public string TooltipText { get; set; }
        public string ActiveBarCall { get; set; }
        public string IconKey { get; set; }
        public Nullable<int> ModuleID { get; set; }
        public Nullable<int> ItemType { get; set; }
        public bool IsModalForm { get; set; }
        public long FKLayoutID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblExplorerBarViewDetail> tblExplorerBarViewDetails { get; set; }
    }
}