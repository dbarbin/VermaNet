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
    
    public partial class tblTaxCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTaxCode()
        {
            this.tblTaxDistricts = new HashSet<tblTaxDistrict>();
        }
    
        public string SalesTaxCode { get; set; }
        public float TotalRate { get; set; }
        public bool SystemDefault { get; set; }
        public string Description { get; set; }
        public bool HasTieredDistrict { get; set; }
        public bool TaxGST { get; set; }
        public bool IsHarmonizedTaxCode { get; set; }
        public string CustomerTaxCode { get; set; }
        public string ItemFullyTaxableCode { get; set; }
        public string ItemProvincialOnlyCode { get; set; }
        public string ItemGSTOnlyCode { get; set; }
        public string ItemExemptCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaxDistrict> tblTaxDistricts { get; set; }
    }
}
