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
    
    public partial class tblPortalLeadQueue
    {
        public int LeadID { get; set; }
        public int ContactNumber { get; set; }
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactName { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string URL { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string PrimaryPhoneNumberFormatted { get; set; }
        public string PrimaryEmailAddress { get; set; }
        public string PrimaryPhoneNumberLocation { get; set; }
        public bool Inactive { get; set; }
        public string PortalPassword { get; set; }
        public string WeatherZipCode { get; set; }
        public Nullable<int> PortalRoleID { get; set; }
        public Nullable<bool> Administered { get; set; }
        public string AdministeredBy { get; set; }
        public string AdminStatus { get; set; }
        public string Comments { get; set; }
        public string AdminComments { get; set; }
    }
}