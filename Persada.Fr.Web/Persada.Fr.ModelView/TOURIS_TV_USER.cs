using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.ModelView
{
   public class TOURIS_TV_USER
    {
            public int ID { get; set; }
            public string USER_ID { get; set; }
            public string USER_MAIL { get; set; }
            public string USER_NAME { get; set; }
            public int USER_DT_ID { get; set; }
            public Nullable<System.DateTime> LAST_LOGIN { get; set; }
            public string PASSWORD { get; set; }
            public System.DateTime CREATED_TIME { get; set; }
            public string CREATED_BY { get; set; }
            public Nullable<System.DateTime> LAST_MODIFIED_TIME { get; set; }
            public string LAST_MODIFIED_BY { get; set; }
            public int ROW_STATUS { get; set; }
    }
}
