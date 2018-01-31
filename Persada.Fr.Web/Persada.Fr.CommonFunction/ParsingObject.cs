using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.CommonFunction
{
    public static class ParsingObject
    {
        /// <summary>
        /// use for retrived data one record
        /// </summary>
        /// <param name="param"></param>
        /// <param name="controller"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static string JsonData(this object param, string controller, string function)
        {
            InvokeUrl url = new InvokeUrl();
            string qryString = null;
            if (param != null)
            {
                qryString = ObjectToDictionaryHelper.GenericObjectToString(param); 
            }
            JObject jsonDes = JObject.Parse(url.ReturnJson(controller, function, qryString));
            return jsonDes["Body"]["Data"][0].ToString();
        }
    }
}

/* sample json kirimin dari api 20-01-2018 bowo
 * respone
{
  "Header": {
    "Status": "1",
    "Message": "Ok"
  },
  "Body": {
    "Aggregates": null,
    "Data": [
      {
        "nama": "Nama",
        "alamat": "Alamat",
        "notelp": "notelp"
      }
    ],
    "Total": 0
  },
  "Footer": null
} 

*request
* http://localhost/Persada.Fr.Web.Api/api/Persada/PersadaString?param={"nama":"Nama","alamat":"Alamat","notelp":"notelp"}
*/
