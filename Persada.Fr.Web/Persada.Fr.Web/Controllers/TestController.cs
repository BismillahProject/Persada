using Newtonsoft.Json;
using Persada.Fr.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Persada.Fr.CommonFunction;
using System.Reflection;
using System.ComponentModel;
using System.Web.Script.Serialization;

namespace Persada.Fr.Web.Controllers
{
    public class TestController : Controller
    {
        public InputForm Index()
        {
            InputForm response = new InputForm();

            InputForm inf = new InputForm()
            {
                nama = "Nama",
                alamat = "Alamat",
                notelp = "notelp"
            };

            response = JsonConvert.DeserializeObject<InputForm>(ParsingObject.JsonData(inf, "Persada", "PersadaString"));
            return response;
        }
    }
}