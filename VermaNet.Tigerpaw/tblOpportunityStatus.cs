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
    
    public partial class tblOpportunityStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOpportunityStatus()
        {
            this.tblOpportunities = new HashSet<tblOpportunity>();
        }
    
        public int OpportunityStatusKeyID { get; set; }
        public string OpportunityStatus { get; set; }
        public int StateOfOpportunity { get; set; }
        public bool SystemEntry { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOpportunity> tblOpportunities { get; set; }
    }
}