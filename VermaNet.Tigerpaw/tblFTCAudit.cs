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
    
    public partial class tblFTCAudit
    {
        public int FTCAuditID { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<int> FKRepNumber { get; set; }
        public string HostName { get; set; }
        public string AppName { get; set; }
        public string SystemName { get; set; }
        public string TypeOfChange { get; set; }
        public string Action { get; set; }
        public int DocNo { get; set; }
        public int DocType { get; set; }
        public string ChangeFromData { get; set; }
        public string ChangeToData { get; set; }
        public System.DateTime ChangeDate { get; set; }
    }
}
