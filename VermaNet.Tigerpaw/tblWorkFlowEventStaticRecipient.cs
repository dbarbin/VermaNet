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
    
    public partial class tblWorkFlowEventStaticRecipient
    {
        public int FKWorkFlowEventDefinitions { get; set; }
        public int RepNumber { get; set; }
        public string ActionRequired { get; set; }
        public string EmailTemplate { get; set; }
        public byte Priority { get; set; }
    
        public virtual tblRep tblRep { get; set; }
        public virtual tblWorkFlowEventDefinition tblWorkFlowEventDefinition { get; set; }
    }
}
