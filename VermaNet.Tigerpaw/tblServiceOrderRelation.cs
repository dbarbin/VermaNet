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
    
    public partial class tblServiceOrderRelation
    {
        public int id { get; set; }
        public int Parent { get; set; }
        public int Child { get; set; }
        public bool StatusFlag { get; set; }
        public bool WorkRequestedFlag { get; set; }
        public bool WorkPerformedFlag { get; set; }
        public bool InternalCommentsFlag { get; set; }
        public bool SOTypeFlag { get; set; }
        public bool AllowTimeOnParentFlag { get; set; }
        public bool AllowTimeOnChildFlag { get; set; }
    }
}