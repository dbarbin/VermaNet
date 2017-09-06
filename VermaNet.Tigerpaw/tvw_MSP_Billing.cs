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
    
    public partial class tvw_MSP_Billing
    {
        public int IsAsset { get; set; }
        public int MSPAccountAssetsKeyID { get; set; }
        public int AccountNumber { get; set; }
        public int ProviderType { get; set; }
        public string ProvidersAssetID { get; set; }
        public int FKMSPAssetTypes { get; set; }
        public Nullable<int> PriceLevel { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool UseFlatPrice { get; set; }
        public string ExternalID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.DateTime> LastPolledDate { get; set; }
        public string Description { get; set; }
        public string AssetType { get; set; }
        public string ProviderDescription { get; set; }
        public int AgreementNumber { get; set; }
        public string SpecialItemID { get; set; }
        public double Quantity { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string SalesTaxCode { get; set; }
        public string InvoiceComments { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string BillName { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillPostalCode { get; set; }
        public string BillCountry { get; set; }
        public string BillPhone { get; set; }
        public string BillContactName { get; set; }
        public string ARCustomerNumber { get; set; }
        public Nullable<System.DateTime> NextBillingPeriod { get; set; }
        public bool AgreementWasAutoBilled { get; set; }
        public string AccountName { get; set; }
        public string IncomeGlCode { get; set; }
        public string CostGlCode { get; set; }
        public decimal BaseCost { get; set; }
        public string ProvidersAssetName { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<System.DateTime> DateRemoved { get; set; }
        public int InActiveIndicator { get; set; }
        public int PrintWhenQtyZero { get; set; }
        public int DeleteAfterInvoice { get; set; }
    }
}