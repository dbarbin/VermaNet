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
    
    public partial class tvw_DashboardSOSymptomsByDate
    {
        public string Symptom { get; set; }
        public int SONumber { get; set; }
        public string BriefDescription { get; set; }
        public int AccountNumber { get; set; }
        public string AccountPhone { get; set; }
        public string AccountPhoneLocation { get; set; }
        public int ContactNumber { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPhoneLocation { get; set; }
        public string RequestedBy { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public Nullable<System.DateTime> TimeReceived { get; set; }
        public Nullable<System.DateTime> DateRequested { get; set; }
        public Nullable<System.DateTime> TimeRequested { get; set; }
        public Nullable<System.DateTime> DateOpened { get; set; }
        public Nullable<System.DateTime> TimeOpened { get; set; }
        public Nullable<System.DateTime> DateClosed { get; set; }
        public Nullable<System.DateTime> TimeClosed { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public int VoidBy { get; set; }
        public string VoidReason { get; set; }
        public string InvoicedStatus { get; set; }
        public string PostedStatus { get; set; }
        public string System { get; set; }
        public string SOType { get; set; }
        public string InvoiceTerms { get; set; }
        public string FreightTerms { get; set; }
        public string PaymentMethod { get; set; }
        public string ShippingMethod { get; set; }
        public string Priority { get; set; }
        public int PriorityRank { get; set; }
        public int TechAssigned { get; set; }
        public int TakenBy { get; set; }
        public int RepToCredit { get; set; }
        public string DirectionsToLocation { get; set; }
        public int EstimatedHrs { get; set; }
        public int EstimatedMins { get; set; }
        public int TotalHours { get; set; }
        public int TotalMinutes { get; set; }
        public float LaborHrs { get; set; }
        public int PriceLevel { get; set; }
        public string SalesTaxCode { get; set; }
        public float SalesTaxRate { get; set; }
        public bool FreightTaxable { get; set; }
        public bool TaxLabor { get; set; }
        public bool Taxable { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal SalesTax { get; set; }
        public bool GSTaxable { get; set; }
        public decimal GSTaxableAmount { get; set; }
        public decimal GSTax { get; set; }
        public decimal DiscountDollars { get; set; }
        public float DiscountPercent { get; set; }
        public decimal Freight { get; set; }
        public decimal TradeIn { get; set; }
        public decimal Deposit { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal TotalCost { get; set; }
        public Nullable<int> ContractNumber { get; set; }
        public bool PrintedFlag { get; set; }
        public decimal BidPrice { get; set; }
        public int InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string Comment { get; set; }
        public bool ResolvedOnPhone { get; set; }
        public int CallBackCount { get; set; }
        public string TagNumber { get; set; }
        public string LoanAgreement { get; set; }
        public string DebitCreditMemo { get; set; }
        public string CustomerPO { get; set; }
        public string DispatchReference { get; set; }
        public string SalesAgreementNumber { get; set; }
        public string Miscellaneous { get; set; }
        public string IBMNumber { get; set; }
        public string OtherReferenceNum { get; set; }
        public string CustomerReference { get; set; }
        public int LineItems { get; set; }
        public string GeneralSymptoms { get; set; }
        public string GeneralResolutions { get; set; }
        public string WarrantyType { get; set; }
        public int MeterReading { get; set; }
        public int NumItemsServiced { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string VerifiedBy { get; set; }
        public Nullable<System.DateTime> VerifiedDate { get; set; }
        public string ARReference { get; set; }
        public Nullable<System.DateTime> ARDate { get; set; }
        public string GLReference { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public string ExternalInvoice { get; set; }
        public string StagingLocation { get; set; }
        public string ServiceCategory { get; set; }
        public int QuoteNumber { get; set; }
        public string BillCompanyName { get; set; }
        public string BillContactName { get; set; }
        public string BillPhoneNumber { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillPostalCode { get; set; }
        public string BillCountry { get; set; }
        public string ShipCompanyName { get; set; }
        public string ShipContactName { get; set; }
        public string ShipPhoneNumber { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string ServiceZone { get; set; }
        public string Reference { get; set; }
        public decimal UnappliedTradeIn { get; set; }
        public float SavingsPercent { get; set; }
        public decimal UnappliedGSTradein { get; set; }
        public decimal UnappliedBOTradein { get; set; }
        public bool CreditsWereInvoiced { get; set; }
        public decimal CreditBalance { get; set; }
        public int OriginalSONumber { get; set; }
        public int PONumber { get; set; }
        public string InternalSOComments { get; set; }
        public string ARCustomerNumber { get; set; }
        public double DiscountMarginPercent { get; set; }
        public decimal DiscountSellForPrice { get; set; }
        public decimal TotalDollarsDiscounted { get; set; }
        public float TotalPercentDiscounted { get; set; }
        public bool GSTIsTaxable { get; set; }
        public Nullable<System.DateTime> BMFLastProcessed { get; set; }
        public short OrderSource { get; set; }
        public bool StatusChangedIndicator { get; set; }
        public Nullable<int> ProjectKeyID { get; set; }
        public Nullable<int> ProjectPhaseKeyID { get; set; }
        public string ProgressiveInvoiceTotalComment { get; set; }
        public decimal ProviderTaxableAmount { get; set; }
        public decimal ProviderTax { get; set; }
        public float ProviderTaxRate { get; set; }
        public bool TaxComputedBeforeTradeIn { get; set; }
        public bool GSTaxComputedBeforeTradeIn { get; set; }
        public float GSTaxRate { get; set; }
        public bool NeedToTestEscalation { get; set; }
        public bool InThresholdEscalationNoticeSent { get; set; }
        public bool PastTargetEscalationNoticeSent { get; set; }
        public string MSPAlertID { get; set; }
        public Nullable<System.DateTime> DateToInstall { get; set; }
        public string ExternalID { get; set; }
        public int ProductType { get; set; }
        public string MSPAlertURL { get; set; }
        public string ContactEmailAddress { get; set; }
        public Nullable<int> FKDispatchBoardKeyID { get; set; }
        public Nullable<int> PriorityColor { get; set; }
        public Nullable<System.DateTime> NextDate { get; set; }
        public int NumberOfTasks { get; set; }
        public int Age { get; set; }
        public int ReceivedDateAge { get; set; }
        public Nullable<decimal> TotalDue { get; set; }
        public decimal TotalLaborCost { get; set; }
        public decimal TotalLaborSellPrice { get; set; }
        public decimal TotalOtherCost { get; set; }
        public decimal TotalOtherSellPrice { get; set; }
        public bool EmailConnectorUpdate { get; set; }
        public bool CanDiscountedItemsGetHeaderDiscount { get; set; }
        public Nullable<System.DateTime> SLADeadline { get; set; }
        public int ActualHoursLogged { get; set; }
        public int ActualMinutesLogged { get; set; }
        public Nullable<System.DateTime> StatusChangeDate { get; set; }
        public Nullable<System.DateTime> SLAWarning { get; set; }
        public int FKPayMethods { get; set; }
        public string DefaultBin { get; set; }
        public bool BillParent { get; set; }
        public bool ReadyToInvoice { get; set; }
        public Nullable<int> Severity { get; set; }
        public Nullable<int> SeverityRank { get; set; }
    }
}