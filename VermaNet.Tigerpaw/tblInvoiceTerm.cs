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
    
    public partial class tblInvoiceTerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInvoiceTerm()
        {
            this.tblPurchaseOrders = new HashSet<tblPurchaseOrder>();
            this.tblServiceOrders = new HashSet<tblServiceOrder>();
        }
    
        public string InvoiceTerms { get; set; }
        public string ARTermsCode { get; set; }
        public int NetDateOfNextMonth { get; set; }
        public int NetDays { get; set; }
        public int DiscountDays { get; set; }
        public float DiscountPercent { get; set; }
        public bool SystemDefault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPurchaseOrder> tblPurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServiceOrder> tblServiceOrders { get; set; }
    }
}
