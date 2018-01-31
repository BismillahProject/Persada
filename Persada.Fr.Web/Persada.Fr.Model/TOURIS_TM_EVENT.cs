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
    
    public partial class TOURIS_TM_EVENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOURIS_TM_EVENT()
        {
            this.TOURIS_TM_EVENT_PHOTO = new HashSet<TOURIS_TM_EVENT_PHOTO>();
        }
    
        public int ID { get; set; }
        public string EVENT_NAME { get; set; }
        public string EVENT_DESCRIPTION { get; set; }
        public int CATEGORY_ID { get; set; }
        public int VILLAGE_ID { get; set; }
        public string ADDRESS { get; set; }
        public System.DateTime START_TIME { get; set; }
        public System.DateTime END_TIME { get; set; }
        public System.DateTime CREATED_TIME { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_MODIFIED_TIME { get; set; }
        public string LAST_MODIFIED_BY { get; set; }
        public int ROW_STATUS { get; set; }
    
        public virtual TOURIS_TM_CATEGORY TOURIS_TM_CATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURIS_TM_EVENT_PHOTO> TOURIS_TM_EVENT_PHOTO { get; set; }
        public virtual TOURIS_TM_VILLAGE TOURIS_TM_VILLAGE { get; set; }
    }
}
