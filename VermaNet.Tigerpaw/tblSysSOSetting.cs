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
    
    public partial class tblSysSOSetting
    {
        public int ID { get; set; }
        public string DefaultNewOrderStatus { get; set; }
        public string DefaultOpenOrderStatus { get; set; }
        public string DefaultClosedOrderStatus { get; set; }
        public string DefaultPriority { get; set; }
        public string DefaultQuoteToSOType { get; set; }
        public string DefaultOrderType { get; set; }
        public string DefaultPaymentMethod { get; set; }
        public string WhoseBilling { get; set; }
        public string TechGroup { get; set; }
        public bool AllowSOReceivedDateTimeOverride { get; set; }
        public bool AutoOpenOrder { get; set; }
        public bool ForceTimeLogs { get; set; }
        public bool AlwaysShowSpecialInst { get; set; }
        public bool UseGeneralResolutionsForInvoiceComments { get; set; }
        public bool CreateTaskForNewServiceOrders { get; set; }
        public int NumberOfRMABins { get; set; }
        public bool DefaultAccountRepAsServiceRepToCredit { get; set; }
        public bool viewRelationsOnNewSOFromSearch { get; set; }
        public bool UseCurrentRepAsTechAssigned { get; set; }
        public bool ShowBriefDescriptionOnDispatchBoard { get; set; }
        public bool PromptForSOCloseOnInvoicing { get; set; }
        public bool RequireContractForNewSO { get; set; }
        public bool AllowLogsToBeEnteredOnClosedOrders { get; set; }
        public int ContractMaintenancePriceLevel { get; set; }
        public bool AllowDeleteOfFilledPartsFromSO { get; set; }
        public bool ForceNewInvoiceOnChanges { get; set; }
        public short ContractMaintenanceBasis { get; set; }
        public bool CopyLogCommentsWithEndTime { get; set; }
        public bool CopyLogCommentsWithCurrentDateTime { get; set; }
        public bool EnforceSOLocking { get; set; }
        public bool LogSOStatusChangesToJournal { get; set; }
        public bool AutoCopyLogCommentsToSO { get; set; }
        public short PrependValue { get; set; }
        public bool UseDefaultContractOnSOFromQuote { get; set; }
        public string DefaultaAutomaticExpirationStatus { get; set; }
        public bool AllowCopyLogCommentsOverride { get; set; }
        public bool CopyLogsToSONotes { get; set; }
        public bool CopyWorkPerformedChangesToSONotes { get; set; }
        public bool RequireTimeEntryEndDate { get; set; }
        public bool DisplayOptionToConvertBillableTimeLogsToLaborItemsAtInvoicing { get; set; }
        public bool AllowSOLevelDiscounts { get; set; }
        public bool UseTimeLogLaborRateOnManualConversionToLabor { get; set; }
    }
}
