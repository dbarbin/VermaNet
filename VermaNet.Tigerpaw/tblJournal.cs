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
    
    public partial class tblJournal
    {
        public int JournalKeyID { get; set; }
        public int AccountNumber { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string JournalTopic { get; set; }
        public string JournalAction { get; set; }
        public int ContactNumber { get; set; }
        public Nullable<int> RepNumber { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public bool SystemGenerated { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblJournalAction tblJournalAction { get; set; }
        public virtual tblJournalTopic tblJournalTopic { get; set; }
        public virtual tblRep tblRep { get; set; }
    }
}