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
    
    public partial class tblAccountSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAccountSource()
        {
            this.tblOpportunities = new HashSet<tblOpportunity>();
        }
    
        public string AccountSource { get; set; }
        public bool SystemEntry { get; set; }
    
        public virtual tblAccountSource tblAccountSources1 { get; set; }
        public virtual tblAccountSource tblAccountSource1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOpportunity> tblOpportunities { get; set; }
    }
}
