//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persada.Fr.ModelView
{
    using System;
    using System.Collections.Generic;
    
    public class TOURIS_TV_EVENT
    {    
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
    }
}
