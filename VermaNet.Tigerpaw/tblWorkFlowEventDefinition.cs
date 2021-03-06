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
    
    public partial class tblWorkFlowEventDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblWorkFlowEventDefinition()
        {
            this.tblWorkflowEventConditionSelectedFields = new HashSet<tblWorkflowEventConditionSelectedField>();
            this.tblWorkFlowEventLogs = new HashSet<tblWorkFlowEventLog>();
            this.tblWorkFlowEventRecipientGroups = new HashSet<tblWorkFlowEventRecipientGroup>();
            this.tblWorkFlowEventStaticRecipients = new HashSet<tblWorkFlowEventStaticRecipient>();
        }
    
        public int WorkFlowEventDefinitionsKeyID { get; set; }
        public string EventName { get; set; }
        public int TypeID { get; set; }
        public int DocumentType { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
        public bool NotifyPrimaryRep { get; set; }
        public bool NotifyAllReps { get; set; }
        public bool NotifyQuoteRep { get; set; }
        public bool NotifyTechAssigned { get; set; }
        public bool NotifyTakenBy { get; set; }
        public bool NotifyPurchaseOrderBuyer { get; set; }
        public bool NotifyTaskScheduledForRep { get; set; }
        public bool NotifyRepCausingEvent { get; set; }
        public bool NotifyRepOnCreditMemo { get; set; }
        public bool DoNotNotifyRepCausingEvent { get; set; }
        public bool CanBeCached { get; set; }
        public bool FlagLogsAsCompletedWhenViewed { get; set; }
        public string WorkFlowDepartment { get; set; }
        public string PrimaryRepActionRequired { get; set; }
        public string AllRepsActionRequired { get; set; }
        public string QuoteRepActionRequired { get; set; }
        public string TechAssignedActionRequired { get; set; }
        public string TakenByActionRequired { get; set; }
        public string PurchaseOrderBuyerActionRequired { get; set; }
        public string TaskScheduledForRepActionRequired { get; set; }
        public string RepCausingEventActionRequired { get; set; }
        public string RepOnCreditMemoActionRequired { get; set; }
        public string ActivityName { get; set; }
        public bool Inactive { get; set; }
        public string PrimaryRepEmailTemplate { get; set; }
        public string RepOnQuoteEmailTemplate { get; set; }
        public string TakenByEmailTemplate { get; set; }
        public string TechAssignedEmailTemplate { get; set; }
        public string AllRepsEmailTemplate { get; set; }
        public string RepOnCreditMemoEmailTemplate { get; set; }
        public string RepCausingEventEmailTemplate { get; set; }
        public string PurchaseOrderBuyerEmailTemplate { get; set; }
        public string RepScheduledForTaskEmailTemplate { get; set; }
        public bool NotifyPrimaryContact { get; set; }
        public bool NotifyContactOnQuote { get; set; }
        public bool NotifyContactOnSO { get; set; }
        public bool NotifyContactOnInvoice { get; set; }
        public bool NotifyContactOnOpportunity { get; set; }
        public bool NotifyContactOnTask { get; set; }
        public bool NotifyContactOnCreditMemo { get; set; }
        public bool NotifyContactAtVendor { get; set; }
        public string PrimaryContactEmailTemplate { get; set; }
        public string ContactOnQuoteEmailTemplate { get; set; }
        public string ContactOnSOEmailTemplate { get; set; }
        public string ContactOnInvoiceEmailTemplate { get; set; }
        public string ContactOnOpportunityEmailTemplate { get; set; }
        public string ContactOnTaskEmailTemplate { get; set; }
        public string ContactOnCreditMemoEmailTemplate { get; set; }
        public string ContactAtVendorEmailTemplate { get; set; }
        public string RepOnProjectActionRequired { get; set; }
        public string RepOnProjectPhaseActionRequired { get; set; }
        public string RepOnProjectEmailTemplate { get; set; }
        public string RepOnProjectPhaseEmailTemplate { get; set; }
        public bool NotifyRepOnProject { get; set; }
        public bool NotifyRepOnProjectPhase { get; set; }
        public string ReplyAddress { get; set; }
        public string DisplayName { get; set; }
        public string ExcludedAccountGroup { get; set; }
        public string ExcludedSOProfile { get; set; }
        public byte NotifyAllRepsPriority { get; set; }
        public byte NotifyRepCausingEventPriority { get; set; }
        public byte NotifyRepOnCreditMemoPriority { get; set; }
        public byte NotifyRepOnProjectPriority { get; set; }
        public byte NotifyRepOnProjectPhasePriority { get; set; }
        public byte NotifyTakenByPriority { get; set; }
        public byte NotifyTaskScheduledForRepPriority { get; set; }
        public byte NotifyTechAssignedPriority { get; set; }
        public byte NotifyPrimaryRepPriority { get; set; }
        public byte NotifyPurchaseOrderBuyerPriority { get; set; }
        public byte NotifyQuoteRepPriority { get; set; }
        public int NumberOfDays { get; set; }
        public bool NotifyCustomerAssetRep { get; set; }
        public string CustomerAssetRepActionRequired { get; set; }
        public string CustomerAssetRepEmailTemplate { get; set; }
        public byte NotifyCustomerAssetRepPriority { get; set; }
        public bool NotifyContractRepToCredit { get; set; }
        public string ContractRepToCreditActionRequired { get; set; }
        public string ContractRepToCreditEmailTemplate { get; set; }
        public byte NotifyContractRepToCreditPriority { get; set; }
        public bool NotifyContractAssignedTech { get; set; }
        public string ContractAssignedTechActionRequired { get; set; }
        public string ContractAssignedTechEmailTemplate { get; set; }
        public byte NotifyContractAssignedTechPriority { get; set; }
        public string NewSOStatus { get; set; }
        public string NewSOPriority { get; set; }
        public int NewSODispatchBoard { get; set; }
        public bool IncludeAssociatedTechs { get; set; }
        public bool PutCustomerOnCreditHold { get; set; }
        public bool NotifyContactOnPaymentMethod { get; set; }
        public string ContactOnPaymentMethodEmailTemplate { get; set; }
        public string NewAccountType { get; set; }
        public bool NotifyTechOnTimeLog { get; set; }
        public string TechOnTimeLogActionRequired { get; set; }
        public string TechOnTimeLogEmailTemplate { get; set; }
        public byte NotifyTechOnTimeLogPriority { get; set; }
        public bool NotifyAccountDefaultServiceTech { get; set; }
        public string AccountDefaultServiceTechActionRequired { get; set; }
        public string AccountDefaultServiceTechEmailTemplate { get; set; }
        public byte NotifyAccountDefaultServiceTechPriority { get; set; }
        public int CampaignNumber { get; set; }
        public string ActivitySpecialInstructions { get; set; }
        public bool NotifyOpportunityOwner { get; set; }
        public string OpportunityOwnerActionRequired { get; set; }
        public string OpportunityOwnerEmailTemplate { get; set; }
        public byte NotifyOpportunityOwnerPriority { get; set; }
        public int CampaignNumberToRemove { get; set; }
    
        public virtual tblWorkFlowDepartment tblWorkFlowDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkflowEventConditionSelectedField> tblWorkflowEventConditionSelectedFields { get; set; }
        public virtual tblWorkFlowEventDocumentType tblWorkFlowEventDocumentType { get; set; }
        public virtual tblWorkFlowEventType tblWorkFlowEventType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkFlowEventLog> tblWorkFlowEventLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkFlowEventRecipientGroup> tblWorkFlowEventRecipientGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkFlowEventStaticRecipient> tblWorkFlowEventStaticRecipients { get; set; }
    }
}
