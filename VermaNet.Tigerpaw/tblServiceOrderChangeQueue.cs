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
    
    public partial class tblServiceOrderChangeQueue
    {
        public int id { get; set; }
        public int SONumber { get; set; }
        public string BriefDescription { get; set; }
        public string Comment { get; set; }
        public int AccountNumber { get; set; }
        public Nullable<int> ContactNumber { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public Nullable<int> TechAssigned { get; set; }
        public string MSPAlertID { get; set; }
        public string ExternalID { get; set; }
        public string ProvidersAssetID { get; set; }
        public Nullable<int> ProductType { get; set; }
        public System.DateTime DateReceived { get; set; }
        public Nullable<System.DateTime> DateRequested { get; set; }
        public Nullable<System.DateTime> DateOpened { get; set; }
        public Nullable<System.DateTime> DateClosed { get; set; }
        public System.DateTime LastModified { get; set; }
    }
}
