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
    
    public partial class tvwr_TimeLogsByServiceOrder
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountID { get; set; }
        public int SONumber { get; set; }
        public int EstimatedHrs { get; set; }
        public int EstimatedMins { get; set; }
        public string BriefDescription { get; set; }
        public int TotalHours { get; set; }
        public int TotalMinutes { get; set; }
        public string Status { get; set; }
        public string SOType { get; set; }
        public Nullable<System.DateTime> DateClosed { get; set; }
        public string Reference { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public Nullable<int> ContractNumber { get; set; }
        public string RepInitials { get; set; }
        public string Description { get; set; }
        public string Basis { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<int> ContractHours { get; set; }
        public Nullable<decimal> RatePerHour { get; set; }
        public string OverUnderIndicator { get; set; }
        public Nullable<int> HoursRemaining { get; set; }
        public Nullable<int> MinutesRemaining { get; set; }
        public Nullable<int> MaxMeter { get; set; }
        public Nullable<int> WarningClicks { get; set; }
        public Nullable<float> OverageChargePerClick { get; set; }
        public Nullable<int> MeterRemaining { get; set; }
        public Nullable<decimal> MaxDollars { get; set; }
        public Nullable<float> WarningPercent { get; set; }
        public Nullable<decimal> DollarsRemaining { get; set; }
        public Nullable<double> MaxUnits { get; set; }
        public Nullable<double> UnitsRemaining { get; set; }
        public Nullable<float> ChargePerUnit { get; set; }
        public Nullable<int> PeriodBaseClicks { get; set; }
        public string PeriodUsageCycle { get; set; }
        public Nullable<decimal> PeriodBaseHours { get; set; }
        public string LogComment { get; set; }
        public decimal Fuel { get; set; }
        public decimal Meals { get; set; }
        public float Mileage { get; set; }
        public decimal MiscExpenses { get; set; }
        public decimal Parking { get; set; }
        public decimal Tolls { get; set; }
        public int LogHours { get; set; }
        public int LogMinutes { get; set; }
        public decimal LogReasonLaborRate { get; set; }
        public int SOLogKeyID { get; set; }
        public bool Chargable { get; set; }
        public bool Billable { get; set; }
        public string TimeLogReason { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public Nullable<int> TypeRegRate { get; set; }
        public Nullable<decimal> TimeLogAmount { get; set; }
    }
}
