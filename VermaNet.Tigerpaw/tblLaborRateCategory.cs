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
    
    public partial class tblLaborRateCategory
    {
        public int LaborRateCategoryKeyID { get; set; }
        public string LaborRateCategory { get; set; }
        public int Type { get; set; }
        public decimal FlatFee { get; set; }
        public int TypeRegRate { get; set; }
        public decimal RegularRateFixed { get; set; }
        public string RegularRatePBItemID { get; set; }
        public int TypeOTRate { get; set; }
        public decimal OvertimeRateFixed { get; set; }
        public decimal OvertimeRateMultiplier { get; set; }
        public string OvertimePBItemID { get; set; }
        public int TypePremRate { get; set; }
        public decimal PremiumRateFixed { get; set; }
        public decimal PremiumRateMultiplier { get; set; }
        public string PremiumRatePBItemID { get; set; }
        public string FlatFeePBItemID { get; set; }
    }
}