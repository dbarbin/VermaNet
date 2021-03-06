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
    
    public partial class tvw_Reps
    {
        public int RepNumber { get; set; }
        public int PersonalAccountNumber { get; set; }
        public bool Inactive { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string RepName { get; set; }
        public string Title { get; set; }
        public string NameOnLetter { get; set; }
        public string SignatureBlock { get; set; }
        public string SignatureGraphic { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string PagerPhone { get; set; }
        public string FaxPhone { get; set; }
        public string OfficePhone { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> DateEmployed { get; set; }
        public string Department { get; set; }
        public string PassWord { get; set; }
        public string Status { get; set; }
        public bool RepIsPublic { get; set; }
        public int UserLevel { get; set; }
        public string Territory { get; set; }
        public string SkillLevel { get; set; }
        public decimal HourlyRate { get; set; }
        public string ReportsTo { get; set; }
        public decimal Quota { get; set; }
        public float Commission { get; set; }
        public string AccountingLinkSalesRepID { get; set; }
        public string DefaultCity { get; set; }
        public string DefaultState { get; set; }
        public string DefaultCountry { get; set; }
        public string DefaultAccountType { get; set; }
        public int DefaultSnooze { get; set; }
        public string WordTemplate { get; set; }
        public string DefaultTemplateDir { get; set; }
        public string FaxPrefix { get; set; }
        public string FaxFromAreaCode { get; set; }
        public string FacSysServerName { get; set; }
        public string FacSysUserName { get; set; }
        public string FacSysPassword { get; set; }
        public bool ShowTooltips { get; set; }
        public bool CreateLabelFile { get; set; }
        public bool CloseSOHistOnShow { get; set; }
        public bool CheckConflicts { get; set; }
        public bool TasktoNote { get; set; }
        public bool DefaultAlarm { get; set; }
        public bool StartMaximized { get; set; }
        public bool ShowLastServiceOrderOnLogin { get; set; }
        public bool ShowLastQuoteOnLogin { get; set; }
        public string LastDocumentPath { get; set; }
        public string DefaultDocumentType { get; set; }
        public bool DefaultLogintoPursuit { get; set; }
        public bool DefaultLogintoService { get; set; }
        public bool DefaultLogintoQuotes { get; set; }
        public bool DefaultLogintoParts { get; set; }
        public int ShowViewOnLogin { get; set; }
        public bool ShowPriceBookSelectOnItemID { get; set; }
        public bool PromptOnApplicationClose { get; set; }
        public bool SpellingCheckSpelling { get; set; }
        public bool SpellingLoadCache { get; set; }
        public bool SpellingIgnoreWithNumbers { get; set; }
        public bool SpellingIgnoreUpperCase { get; set; }
        public bool SpellingIgnoreMixedCase { get; set; }
        public string SpellingCustomDictionary { get; set; }
        public int ReminderQuantity { get; set; }
        public int ReminderInterval { get; set; }
        public bool SendMailUsingOutlook { get; set; }
        public int CheckRemindersInterval { get; set; }
        public float CalendarTopTime { get; set; }
        public string ReportsPath { get; set; }
        public bool UseQuoteTemplates { get; set; }
        public bool ClearPreviousConnections { get; set; }
        public int WorkFlowCacheTime { get; set; }
        public bool PrintSpecialInstructions { get; set; }
        public bool PrintItemsServiced { get; set; }
        public bool PrintPartsLaborUsedWithPrices { get; set; }
        public bool PrintPartsLaborUsedWithoutPrices { get; set; }
        public bool PrintPartsLaborUsedSerialNumbers { get; set; }
        public bool PrintTimeLogRecords { get; set; }
        public bool PrintServiceOrderNotes { get; set; }
        public bool PrintAssemblyDetailRecords { get; set; }
        public bool PrintContractInformation { get; set; }
        public string SyncInventoryLocation { get; set; }
        public bool AccountsCanBeReassigned { get; set; }
        public string AccountViewContactGridSettings { get; set; }
        public Nullable<System.DateTime> ChangedPasswordDate { get; set; }
        public string NTLoginName { get; set; }
        public bool FastPriceBookSearch { get; set; }
        public string DefaultSearchFieldOnPriceBookSelect { get; set; }
        public bool LookupCityStateByZip { get; set; }
        public int DefaultReminderQuantity { get; set; }
        public int DefaultReminderInterval { get; set; }
        public bool DontRestoreJournalListFilterSettings { get; set; }
        public bool CanHotSyncPursuit { get; set; }
        public bool CanHotSyncService { get; set; }
        public bool AlwaysLogEmailsToJournal { get; set; }
        public bool ShowTipsOnStartup { get; set; }
        public bool AlwaysShowOutlookSendDialogBox { get; set; }
        public bool EnlargePopupsForBigScreens { get; set; }
        public bool CanAccessIVR { get; set; }
        public bool ReturnToFiltersOnListViews { get; set; }
        public bool CanAccessWebInterface { get; set; }
        public bool SOPrintSpecialInstructions { get; set; }
        public bool SOPrintServiceOrderNotes { get; set; }
        public bool SOPrintPartsLaborWithPrices { get; set; }
        public bool SOPrintPartsLaborWithoutPrices { get; set; }
        public bool SOPrintTimeLogs { get; set; }
        public bool SOPrintContractInformation { get; set; }
        public string PBSearchForText { get; set; }
        public string PBSearchInField { get; set; }
        public string PBFilterBy { get; set; }
        public string PBShowWhat { get; set; }
        public int PBPriceLevel { get; set; }
        public bool PBRememberSettings { get; set; }
        public bool PBHideInactiveItems { get; set; }
        public int TigerpawInterfaceStyle { get; set; }
        public bool RetainLogTech { get; set; }
        public bool RetainLogComment { get; set; }
        public bool RetainLogReason { get; set; }
        public bool RetainLogStartDate { get; set; }
        public bool RetainLogStartTime { get; set; }
        public bool RetainLogEndDate { get; set; }
        public bool RetainLogEndTime { get; set; }
        public bool UseLogStartDateAsEndDate { get; set; }
        public int CalendarViewPrimeColor { get; set; }
        public int CalendarViewNonPrimeColor { get; set; }
        public string DefaultWarehouse { get; set; }
        public string VehicleID { get; set; }
        public Nullable<bool> DefaultEmailToHTML { get; set; }
        public string HomePhoneExt { get; set; }
        public string MobilePhoneExt { get; set; }
        public string PagerPhoneExt { get; set; }
        public string FaxPhoneExt { get; set; }
        public string OfficePhoneExt { get; set; }
        public string PBItemSubCategory { get; set; }
        public string PBItemCategory { get; set; }
        public string PBItemType { get; set; }
        public string CheckSum { get; set; }
        public short BatchTimeEntryStartUpMode { get; set; }
        public bool ShowOnlyActiveContractsInGrid { get; set; }
        public int CalendarViewTimeInterval { get; set; }
        public int GroupCalendarViewZoomLevel { get; set; }
        public int ProjectViewTimelineZoom { get; set; }
        public float BillablePercent { get; set; }
        public bool CustomerPortalAdmin { get; set; }
        public Nullable<int> FKRepNumber { get; set; }
        public string EmailSignatureText { get; set; }
        public string EmailSignatureHTML { get; set; }
        public string DefaultTaskType { get; set; }
        public Nullable<int> GridBackColorEven { get; set; }
        public Nullable<int> GridBackColorOdd { get; set; }
        public Nullable<int> GridForeColorEven { get; set; }
        public Nullable<int> GridForeColorOdd { get; set; }
        public Nullable<int> GridFirstColumnBackColor { get; set; }
        public Nullable<bool> GridFirstColumnHasBackColor { get; set; }
        public Nullable<int> GridDividerStyle { get; set; }
        public Nullable<int> GridDividerType { get; set; }
        public byte[] CustomToolbar { get; set; }
        public Nullable<int> JournalHideSystemEntry { get; set; }
        public Nullable<int> NavigatorStyle { get; set; }
        public string MapService { get; set; }
        public byte[] CustomDictionary { get; set; }
        public Nullable<bool> SuppressWorkflowPopup { get; set; }
        public Nullable<bool> SuppressReminderPopup { get; set; }
        public string DefaultEmailTemplateName { get; set; }
        public Nullable<decimal> SundayHours { get; set; }
        public Nullable<decimal> MondayHours { get; set; }
        public Nullable<decimal> TuesdayHours { get; set; }
        public Nullable<decimal> WednesdayHours { get; set; }
        public Nullable<decimal> ThursdayHours { get; set; }
        public Nullable<decimal> FridayHours { get; set; }
        public Nullable<decimal> SaturdayHours { get; set; }
        public Nullable<int> EmailStatsChartType { get; set; }
    }
}
