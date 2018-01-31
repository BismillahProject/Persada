using Persada.Fr.Model;
using Persada.Fr.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.Facade
{
    public class Persada_Fc : ApiResData
    {
        public ApiGridResponse TestGetDataTable(InputForm fm)
        {
            ApiGridResponse res = new ApiGridResponse();
            try
            {
                InputForm inf = new InputForm()
                {
                    nama = fm.nama,
                    alamat = fm.alamat,
                    notelp = fm.notelp
                };
                res = ResGetDataTable(new object[] { inf }, null);
            }
            catch (Exception ex)
            {
                res = ResGetDataTable(null, ex);
            }

            return res;
        }



    }
}
