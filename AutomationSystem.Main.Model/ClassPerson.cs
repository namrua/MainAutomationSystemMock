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
    
    public partial class ClassPerson
    {
        public long ClassPersonId { get; set; }
        public long ClassId { get; set; }
        public long PersonId { get; set; }
        public AutomationSystem.Base.Contract.Enums.PersonRoleTypeEnum RoleTypeId { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual PersonRoleType PersonRoleType { get; set; }
        public virtual Person Person { get; set; }
        public virtual Class Class { get; set; }
    }
}
