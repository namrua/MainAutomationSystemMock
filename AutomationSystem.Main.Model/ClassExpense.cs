//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutomationSystem.Main.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClassExpense
    {
        public long ClassExpenseId { get; set; }
        public long ClassBusinessId { get; set; }
        public int Order { get; set; }
        public string Text { get; set; }
        public AutomationSystem.Base.Contract.Enums.ClassExpenseTypeEnum ClassExpenseTypeId { get; set; }
        public Nullable<decimal> Value { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ClassBusiness ClassBusiness { get; set; }
        public virtual ClassExpenseType ClassExpenseType { get; set; }
    }
}
