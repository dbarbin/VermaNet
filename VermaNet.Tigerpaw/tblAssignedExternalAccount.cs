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
    
    public partial class tblAssignedExternalAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAssignedExternalAccount()
        {
            this.tblMSPAccountAssets = new HashSet<tblMSPAccountAsset>();
        }
    
        public int AssignedExternalAccountsKeyId { get; set; }
        public int FKAccountNumber { get; set; }
        public int FKExternalProducts { get; set; }
        public string ExternalID { get; set; }
        public string Comment { get; set; }
        public string ExternalSystemID { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblExternalProduct tblExternalProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMSPAccountAsset> tblMSPAccountAssets { get; set; }
    }
}