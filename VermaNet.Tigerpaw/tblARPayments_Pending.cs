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
    
    public partial class tblARPayments_Pending
    {
        public int ARPayments_PendingKeyID { get; set; }
        public int FKARReceipts_Pending { get; set; }
        public int BatchNumber { get; set; }
        public Nullable<System.DateTime> BatchDate { get; set; }
        public string ARCustomerNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public string ARTermsCode { get; set; }
        public string AccountingLinkSalesRepID { get; set; }
        public decimal ApplyToARAmount { get; set; }
        public decimal ApplyToDiscountAmount { get; set; }
        public decimal ApplyToPaymentAmount { get; set; }
        public string PaymentGLAccount { get; set; }
        public string PaymentDepartment { get; set; }
        public string TermsDiscountGLAccount { get; set; }
        public string TermsDiscountDepartment { get; set; }
        public string ReceivablesGLAccount { get; set; }
        public string ReceivablesDepartment { get; set; }
        public string Comment { get; set; }
        public string SalesTaxCode { get; set; }
        public bool DoNotExportToAccounting { get; set; }
        public string PaymentTransactionID { get; set; }
        public bool Transferred { get; set; }
        public int CentralBillingSequenceNumber { get; set; }
    
        public virtual tblARReceipts_Pending tblARReceipts_Pending { get; set; }
    }
}
