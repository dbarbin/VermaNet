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
    
    public partial class tblPriority
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPriority()
        {
            this.tblServiceOrders = new HashSet<tblServiceOrder>();
            this.tblSOTemplates = new HashSet<tblSOTemplate>();
        }
    
        public string Priority { get; set; }
        public int ResponseTime { get; set; }
        public bool Response24x7 { get; set; }
        public int Rank { get; set; }
        public bool SystemDefault { get; set; }
        public int WarningThreshold { get; set; }
        public short ReportingPeriod { get; set; }
        public int Color { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServiceOrder> tblServiceOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSOTemplate> tblSOTemplates { get; set; }
    }
}