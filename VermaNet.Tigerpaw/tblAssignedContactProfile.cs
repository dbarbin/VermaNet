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
    
    public partial class tblAssignedContactProfile
    {
        public int ContactNumber { get; set; }
        public string ContactProfile { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
    
        public virtual tblContactProfile tblContactProfile { get; set; }
        public virtual tblContact tblContact { get; set; }
    }
}