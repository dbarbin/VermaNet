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
    
    public partial class tblPhysicalInventorySerialNumber
    {
        public int FKPhysicalInventory { get; set; }
        public string SerialNumber { get; set; }
        public bool CountedIndicator { get; set; }
        public bool NewSerialNumber { get; set; }
    
        public virtual tblPhysicalInventory tblPhysicalInventory { get; set; }
    }
}
