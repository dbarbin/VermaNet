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
    
    public partial class tvw_ARPayments
    {
        public System.DateTime ReceiptDate { get; set; }
        public string AccountName { get; set; }
        public string ReceiptReference { get; set; }
        public int ARPaymentsInvoiceNumber { get; set; }
        public decimal ApplyToARAmount { get; set; }
        public decimal ApplyToDiscountAmount { get; set; }
        public decimal ApplyToPaymentAmount { get; set; }
        public string ARPaymentsARCustomerNumber { get; set; }
        public int AccountNumber { get; set; }
        public string PrimaryPhoneNumberFormatted { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public int BatchNumber { get; set; }
        public bool DoNotExportToAccounting { get; set; }
    }
}