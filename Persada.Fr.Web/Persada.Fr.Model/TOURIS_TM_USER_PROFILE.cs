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
    
    public partial class TOURIS_TM_USER_PROFILE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOURIS_TM_USER_PROFILE()
        {
            this.TOURIS_TM_USER_PROFILE_SOSMED = new HashSet<TOURIS_TM_USER_PROFILE_SOSMED>();
        }
    
        public int ID { get; set; }
        public int USER_ID_ID { get; set; }
        public byte[] PHOTO { get; set; }
        public string GENDER { get; set; }
        public Nullable<System.DateTime> BORN { get; set; }
        public string ADDRESS { get; set; }
        public string DESCRIPTION { get; set; }
        public string JOB { get; set; }
        public string COMPANY { get; set; }
        public string HOBBY { get; set; }
        public System.DateTime CREATED_TIME { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_TIME { get; set; }
        public string LAST_MODIFIED_BY { get; set; }
        public int ROW_STATUS { get; set; }
    
        public virtual TOURIS_TM_USER TOURIS_TM_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURIS_TM_USER_PROFILE_SOSMED> TOURIS_TM_USER_PROFILE_SOSMED { get; set; }
    }
}
