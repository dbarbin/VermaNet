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
    
    public partial class tvw_TimeTransactions
    {
        public int KeyID { get; set; }
        public int RecordType { get; set; }
        public int SONumber { get; set; }
        public int Tech { get; set; }
        public string TimeLogReason { get; set; }
        public string LogComment { get; set; }
        public int LogHours { get; set; }
        public int LogMinutes { get; set; }
        public int ElapsedHours { get; set; }
        public int ElapsedMinutes { get; set; }
        public int Chargable { get; set; }
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
        public int ContractNumber { get; set; }
        public string RepName { get; set; }
        public string ViewKeyID { get; set; }
        public string TechInitials { get; set; }
        public Nullable<int> TotalTimeInMinutes { get; set; }
        public int RepNumber { get; set; }
        public string Status { get; set; }
        public long PrintID { get; set; }
    }
}
