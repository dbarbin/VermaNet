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
    
    public partial class tblQuoteNote
    {
        public int QuoteNoteNumber { get; set; }
        public int QuoteNumber { get; set; }
        public string QuoteNote { get; set; }
        public Nullable<int> RepNumber { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime NoteDate { get; set; }
        public string QuoteNoteTopic { get; set; }
        public Nullable<int> ContactNumber { get; set; }
    
        public virtual tblQuoteNoteTopic tblQuoteNoteTopic { get; set; }
        public virtual tblQuote tblQuote { get; set; }
    }
}