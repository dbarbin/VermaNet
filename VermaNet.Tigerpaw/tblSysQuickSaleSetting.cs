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
    
    public partial class tblSysQuickSaleSetting
    {
        public int ID { get; set; }
        public string TaxCode { get; set; }
        public string InvoiceTerms { get; set; }
        public string Location { get; set; }
        public string Printer { get; set; }
        public int HouseAccountNumber { get; set; }
        public bool UseHouseAccountForNewInvoices { get; set; }
        public int PriceLevel { get; set; }
        public bool UseAccountRep { get; set; }
        public string ReceiptReference { get; set; }
        public string InvoiceReportFile { get; set; }
        public bool AllowQuickSaleDiscounts { get; set; }
    }
}