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
    
    public partial class tvw_LV_Portal_Quotes
    {
        public int AccountNumber { get; set; }
        public int QuoteNumber { get; set; }
        public string QuoteDescription { get; set; }
        public decimal TotalNetInvoice { get; set; }
        public Nullable<System.DateTime> QuoteDate { get; set; }
        public string SignedBy { get; set; }
        public Nullable<System.DateTime> QuoteExpirationDate { get; set; }
        public int WorkorderNumber { get; set; }
        public string STATUS { get; set; }
        public int SONumber { get; set; }
        public int InvoiceNumber { get; set; }
    }
}
