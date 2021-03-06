﻿using Newtonsoft.Json.Linq;
using Persada.Fr.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Persada.Fr.Facade;
using Newtonsoft.Json;

namespace Persada.Fr.We.Api.Controllers
{
    public class PersadaController : ApiController
    {
        [HttpGet]
        public JObject PersadaString(string param)
        {
            Persada_Fc persadaF = new Persada_Fc();
            InputForm xx = JsonConvert.DeserializeObject<InputForm>(param);
            return JObject.FromObject(persadaF.TestGetDataTable(xx));
        }

    }
}
