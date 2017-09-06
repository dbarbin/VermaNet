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
    
    public partial class tvw_LVTimeTransactions
    {
        public Nullable<int> Accept { get; set; }
        public Nullable<int> Reject { get; set; }
        public Nullable<int> SONumber { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<int> LogHours { get; set; }
        public Nullable<int> LogMinutes { get; set; }
        public int FilterHours { get; set; }
        public int FilterMinutes { get; set; }
        public Nullable<int> ActualHours { get; set; }
        public Nullable<int> ActualMinutes { get; set; }
        public int FilterActualHours { get; set; }
        public int FilterActualinutes { get; set; }
        public Nullable<int> UtilizedHours { get; set; }
        public Nullable<short> UtilizedMinutes { get; set; }
        public int FilterUtilizedHours { get; set; }
        public short FilterUtilizedinutes { get; set; }
        public string TechRepName { get; set; }
        public int TechRepNumber { get; set; }
        public string TimeLogReason { get; set; }
        public Nullable<int> AcceptanceStatusImage { get; set; }
        public string LogComment { get; set; }
        public Nullable<bool> Chargable { get; set; }
        public Nullable<bool> Billable { get; set; }
        public Nullable<bool> Personal { get; set; }
        public Nullable<float> UnitFactor { get; set; }
        public Nullable<double> TotalUnits { get; set; }
        public Nullable<double> TimeConvertedToLaborItem { get; set; }
        public Nullable<int> ContractNumber { get; set; }
        public string BriefDescription { get; set; }
        public string GeneralResolutions { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int ID { get; set; }
        public int KeyID { get; set; }
        public int RecordType { get; set; }
        public byte AcceptanceStatus { get; set; }
        public string Status { get; set; }
        public string RejectedStatusReason { get; set; }
        public int DeductHours { get; set; }
        public short DeductMinutes { get; set; }
        public Nullable<bool> ApplyMinimum { get; set; }
        public System.DateTime SortStartTime { get; set; }
        public Nullable<System.DateTime> SortEndTime { get; set; }
        public int RateBasis { get; set; }
        public int RateType { get; set; }
        public decimal LogReasonLaborRate { get; set; }
        public int RepUtilizationHours { get; set; }
        public short RepUtilizationMinutes { get; set; }
        public bool CreditUtilizationTime { get; set; }
        public Nullable<int> LaborRateCategoryKeyID { get; set; }
        public string InternalComments { get; set; }
        public int CopyCommentsIndicator { get; set; }
        public int BillForUtilizedTime { get; set; }
        public int ElapsedHours { get; set; }
        public int ElapsedMinutes { get; set; }
        public Nullable<int> RoundingToNearestMinutes { get; set; }
        public Nullable<int> MinimumMinutes { get; set; }
        public Nullable<byte> BackColorRed { get; set; }
        public Nullable<byte> BackColorGreen { get; set; }
        public Nullable<byte> BackColorBlue { get; set; }
        public long PrintID { get; set; }
        public int TimeToInvoice { get; set; }
        public string InvoiceBasis { get; set; }
    }
}