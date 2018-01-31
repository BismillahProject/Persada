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
    public class CountryController : Controller
    {
        CountryFacade countryF = new CountryFacade();
        public JObject RetrieveObjCountryList()
        {            
            return JObject.FromObject(countryF.RetrieveDataCountryList());
        }

        public JObject RetrieveObjCountry(string param)
        {
            TOURIS_TV_COUNTRY country = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(param);
            return JObject.FromObject(countryF.RetrieveDataCountry(country));
        }

        public JObject InsertObjCountry(string param)
        {
            TOURIS_TV_COUNTRY country = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(param);
            return JObject.FromObject(countryF.InsertDataCountry(country));
        }

        public JObject EditObjCountry(string param)
        {
            TOURIS_TV_COUNTRY country = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(param);
            return JObject.FromObject(countryF.EditDataCountry(country));
        }

        public JObject DeleteObjCountry(string param)
        {
            TOURIS_TV_COUNTRY country = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(param);
            return JObject.FromObject(countryF.DeleteDataCountry(country));
        }
    }
}
