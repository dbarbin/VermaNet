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
    
    public partial class tvwr_SOLogsDistinctRepNotAssignedAGroup
    {
        public int SOLogKeyID { get; set; }
        public int SONumber { get; set; }
        public int AccountNumber { get; set; }
        public int Tech { get; set; }
        public string TimeLogReason { get; set; }
        public int ContractNumber { get; set; }
        public string LogComment { get; set; }
        public int LogHours { get; set; }
        public int LogMinutes { get; set; }
        public int ElapsedHours { get; set; }
        public int ElapsedMinutes { get; set; }
        public string Priority { get; set; }
        public int PriorityRank { get; set; }
        public bool Chargable { get; set; }
        public bool Billable { get; set; }
        public float UnitFactor { get; set; }
        public double TotalUnits { get; set; }
        public float Mileage { get; set; }
        public decimal Fuel { get; set; }
        public decimal Parking { get; set; }
        public decimal Tolls { get; set; }
        public decimal Meals { get; set; }
        public decimal Accomodations { get; set; }
        public decimal MiscExpenses { get; set; }
        public Nullable<decimal> TotalExpenses { get; set; }
        public int UsageInvoiceNumber { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public double TimeConvertedToLaborItem { get; set; }
        public decimal LogReasonLaborRate { get; set; }
        public int RateType { get; set; }
        public int RateBasis { get; set; }
        public int CopyCommentsIndicator { get; set; }
        public byte AcceptanceStatus { get; set; }
        public string RejectedStatusReason { get; set; }
        public string InternalComments { get; set; }
        public bool ApplyMinimum { get; set; }
        public int AcceptOrRejectedBy { get; set; }
        public int DeductHours { get; set; }
        public short DeductMinutes { get; set; }
        public int UtilizationHours { get; set; }
        public short UtilizationMinutes { get; set; }
        public bool CreditUtilizationTime { get; set; }
        public bool BillForUtilizedTime { get; set; }
        public System.DateTime DateCreated { get; set; }
        public decimal TechLaborRate { get; set; }
    }
}