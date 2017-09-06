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
    
    public partial class tblTemplateImportPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTemplateImportPart()
        {
            this.tblTemplateImportPartsAssemblies = new HashSet<tblTemplateImportPartsAssembly>();
        }
    
        public int PartsKey { get; set; }
        public int TemplateKey { get; set; }
        public int OldPartsKey { get; set; }
        public Nullable<int> SequenceNumber { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public decimal Quantity { get; set; }
        public short PricingMethod { get; set; }
        public decimal FixedPrice { get; set; }
        public short PriceLevel { get; set; }
        public string Type { get; set; }
        public string AssemblyType { get; set; }
        public bool CommentOnly { get; set; }
        public string Memo { get; set; }
        public bool PrintOnInvoice { get; set; }
    
        public virtual tblTemplateImportHeader tblTemplateImportHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTemplateImportPartsAssembly> tblTemplateImportPartsAssemblies { get; set; }
    }
}