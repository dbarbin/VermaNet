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
    
    public partial class tblLinkRule
    {
        public int RuleNumber { get; set; }
        public int RuleLineNumber { get; set; }
        public string RuleType { get; set; }
        public string OutputType { get; set; }
        public string OutputTable { get; set; }
        public string OutputData { get; set; }
        public int NewRuleNumber { get; set; }
        public string DataType { get; set; }
        public string OutputFormat { get; set; }
        public bool ExitRule { get; set; }
        public string TestType { get; set; }
        public string TestTable { get; set; }
        public string TestData { get; set; }
        public string ComparisonType { get; set; }
        public string ComparisonTable { get; set; }
        public string ComparisonData { get; set; }
        public string SeekOperator { get; set; }
        public string SeekIndex { get; set; }
        public string SeekType { get; set; }
        public string SeekTable { get; set; }
        public string SeekData { get; set; }
        public string Operator { get; set; }
        public double Operand { get; set; }
        public Nullable<byte> NumberOfDecimalPlaces { get; set; }
    
        public virtual tblLinkRuleMaster tblLinkRuleMaster { get; set; }
    }
}