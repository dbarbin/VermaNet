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
    
    public partial class tblNonStockConversionDefault
    {
        public int NonStockConversionKeyID { get; set; }
        public string NonStockItemType { get; set; }
        public string StockItemType { get; set; }
        public string ItemCategory { get; set; }
        public string ReceivingGLCode { get; set; }
        public string IncomeGLCode { get; set; }
        public string CostGLCode { get; set; }
        public bool Serialized { get; set; }
    }
}