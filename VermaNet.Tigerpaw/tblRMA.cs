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
    
    public partial class tblRMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRMA()
        {
            this.tblRMADetails = new HashSet<tblRMADetail>();
        }
    
        public int RMAKeyID { get; set; }
        public string RMANumber { get; set; }
        public string Reference { get; set; }
        public string Comments { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string ContactName { get; set; }
        public string ConfirmTo { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public bool Complete { get; set; }
        public string HoldingLocation { get; set; }
        public string VendorPhone { get; set; }
        public string VendorFax { get; set; }
        public string VendorEmail { get; set; }
        public int VendorAccountNumber { get; set; }
        public int NumberOfItems { get; set; }
        public int BinLocation { get; set; }
        public string GLCode { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRMADetail> tblRMADetails { get; set; }
    }
}