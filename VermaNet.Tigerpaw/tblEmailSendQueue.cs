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
    
    public partial class tblEmailSendQueue
    {
        public int ID { get; set; }
        public int RepNumber { get; set; }
        public bool isDraft { get; set; }
        public string EmlData { get; set; }
        public System.DateTime DateModified { get; set; }
        public bool IsUrgent { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public Nullable<int> ActivityID { get; set; }
        public Nullable<int> CampaignID { get; set; }
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string ReplyToName { get; set; }
        public string ReplyToAddress { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public Nullable<int> DocumentType { get; set; }
        public Nullable<int> DocumentNumber { get; set; }
        public int ContactNumber { get; set; }
        public bool CreateJournalEntry { get; set; }
        public bool IsBodyEncrypted { get; set; }
    }
}
