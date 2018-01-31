using Newtonsoft.Json.Linq;
using Persada.Fr.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Persada.Fr.Facade;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace Persada.Fr.We.Api.Controllers
{
    public class UserController : Controller
    {
        UserFacade userF = new UserFacade();
        public JObject RetrieveObjUser()
        {            
            return JObject.FromObject(userF.RetrieveDataUser());
        }

        public JObject InsertObjUser(string param)
        {
            TOURIS_TV_USER user = JsonConvert.DeserializeObject<TOURIS_TV_USER>(param);
            return JObject.FromObject(userF.InsertDataUser(user));
        }

        public JObject EditObjUser(string param)
        {
            TOURIS_TV_USER user = JsonConvert.DeserializeObject<TOURIS_TV_USER>(param);
            return JObject.FromObject(userF.EditDataUser(user));
        }

        public JObject DeleteObjUser(string param)
        {
            TOURIS_TV_USER user = JsonConvert.DeserializeObject<TOURIS_TV_USER>(param);
            return JObject.FromObject(userF.DeleteDataUser(user));
        }
    }
}
