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
    
    public partial class tblProjectPhaseTemplatesPhaseAssignment
    {
        public string ProjectPhaseTemplateName { get; set; }
        public int ProjectPhaseKeyID { get; set; }
        public int OrdinalPosition { get; set; }
    
        public virtual tblProjectPhaseTemplate tblProjectPhaseTemplate { get; set; }
    }
}