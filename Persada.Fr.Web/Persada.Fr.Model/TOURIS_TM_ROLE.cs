//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persada.Fr.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOURIS_TM_ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOURIS_TM_ROLE()
        {
            this.TOURIS_TM_ROLE_MENU = new HashSet<TOURIS_TM_ROLE_MENU>();
            this.TOURIS_TM_USER_DT = new HashSet<TOURIS_TM_USER_DT>();
        }
    
        public int ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_DESCRIPTION { get; set; }
        public int IS_ACTIVE { get; set; }
        public System.DateTime CREATED_TIME { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_TIME { get; set; }
        public string LAST_MODIFIED_BY { get; set; }
        public int ROW_STATUS { get; set; }
        public Nullable<int> DEFAULT_SELECTED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURIS_TM_ROLE_MENU> TOURIS_TM_ROLE_MENU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURIS_TM_USER_DT> TOURIS_TM_USER_DT { get; set; }
    }
}
