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
    
    public partial class tblCreditMemoSerial
    {
        public int CreditMemoSerialsKeyID { get; set; }
        public int CreditMemoNumber { get; set; }
        public string SerialNumber { get; set; }
        public int FKCreditMemoDetail { get; set; }
        public int FKCreditMemoAssemblyDetail { get; set; }
        public int FKCustomerInventory { get; set; }
        public int FKCustomerInventoryAssemblyDetail { get; set; }
    
        public virtual tblCreditMemo tblCreditMemo { get; set; }
    }
}