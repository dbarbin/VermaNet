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
    
    public partial class tblARReceipts_Pending
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblARReceipts_Pending()
        {
            this.tblARPayments_Pending = new HashSet<tblARPayments_Pending>();
        }
    
        public int ARReceipts_PendingKeyID { get; set; }
        public int AccountNumber { get; set; }
        public string AccountingCompanyID { get; set; }
        public string ReceiptReference { get; set; }
        public string PaymentMethod { get; set; }
        public System.DateTime ReceiptDate { get; set; }
        public string Payor { get; set; }
        public decimal ReceiptAmount { get; set; }
        public decimal TotalAmountApplied { get; set; }
        public string UnappliedPaymentARCustomerNumber { get; set; }
        public int FkPayMethods { get; set; }
        public string PaymentTransactionID { get; set; }
        public int ServiceID { get; set; }
        public int Status { get; set; }
        public bool Transferred { get; set; }
        public int FKARReceiptKeyID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblARPayments_Pending> tblARPayments_Pending { get; set; }
    }
}