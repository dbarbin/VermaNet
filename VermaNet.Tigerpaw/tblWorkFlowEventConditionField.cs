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
    
    public partial class tblWorkFlowEventConditionField
    {
        public int WorkflowEventConditionFieldsKeyID { get; set; }
        public int FKWorkflowEventConditionDataSources { get; set; }
        public string TigerpawFieldName { get; set; }
        public string FieldDataType { get; set; }
        public Nullable<int> FieldLength { get; set; }
        public string FieldDescription { get; set; }
        public string ConditionLookupTable { get; set; }
        public string ConditionDisplayField { get; set; }
        public string ConditionKeyField { get; set; }
        public string ConditionLookupQuery { get; set; }
        public string ComparisonDataTable { get; set; }
        public string ComparisonDataTableKeyFieldName { get; set; }
        public string ComparisonDataTableOtherFieldName { get; set; }
        public string ComparisonDataTableAdditionalCriteria { get; set; }
        public bool IsGroup { get; set; }
        public bool UseNonStrictCombo { get; set; }
        public bool UseSearch { get; set; }
        public bool IsPhoneNumber { get; set; }
    
        public virtual tblWorkFlowEventConditionDataSource tblWorkFlowEventConditionDataSource { get; set; }
    }
}
