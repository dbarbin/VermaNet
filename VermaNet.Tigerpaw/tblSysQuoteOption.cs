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
    
    public partial class tblSysQuoteOption
    {
        public int id { get; set; }
        public string RTFData { get; set; }
        public int ManufacturerLength { get; set; }
        public int PartNumberLength { get; set; }
        public string Separator { get; set; }
        public string DefaultPercentChargeItemID { get; set; }
        public string DefaultPercentDiscountItemID { get; set; }
        public bool FindItemUsingTigerpawPartNumber { get; set; }
        public bool NewQuoteRequiresAnOpportunity { get; set; }
        public string GreatAmericaLeasingDealerID { get; set; }
        public string GreatAmericaLeasingUserName { get; set; }
        public string GreatAmericaLeasingPassword { get; set; }
        public bool AllowQuoteLevelDiscounts { get; set; }
    }
}