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
    
    public partial class tblGridColumn
    {
        public int GridColumnsKeyID { get; set; }
        public int FKGridSettings { get; set; }
        public int ColumnWidth { get; set; }
        public int ColumnPosition { get; set; }
        public string ColumnName { get; set; }
    
        public virtual tblGridSetting tblGridSetting { get; set; }
    }
}
