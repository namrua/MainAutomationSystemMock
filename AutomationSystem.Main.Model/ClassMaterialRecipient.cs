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
    
    public partial class ClassMaterialRecipient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassMaterialRecipient()
        {
            this.ClassMaterialDownloadLogs = new HashSet<ClassMaterialDownloadLog>();
        }
    
        public long ClassMaterialRecipientId { get; set; }
        public AutomationSystem.Base.Contract.Enums.EntityTypeEnum RecipientTypeId { get; set; }
        public long RecipientId { get; set; }
        public long ClassMaterialId { get; set; }
        public string Password { get; set; }
        public string RequestCode { get; set; }
        public Nullable<AutomationSystem.Base.Contract.Enums.LanguageEnum> LanguageId { get; set; }
        public Nullable<int> DownloadLimit { get; set; }
        public Nullable<System.DateTime> Notified { get; set; }
        public bool IsLocked { get; set; }
        public Nullable<System.DateTime> Locked { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ClassMaterial ClassMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassMaterialDownloadLog> ClassMaterialDownloadLogs { get; set; }
    }
}