using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Persada.Fr.ModelView;
using System.Collections.Generic;
using Newtonsoft.Json;
using Persada.Fr.CommonFunction;

namespace Persada.Fr.Web.Controllers
{
    public class UserController : Controller
    {     
           
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Index()
        {
            List<TOURIS_TV_USER> userRes = new List<TOURIS_TV_USER>();

            userRes = JsonConvert.DeserializeObject<List<TOURIS_TV_USER>>(ParsingObject.JsonData(null, "User", "RetrieveObjUser"));
            return View(userRes);
        }

        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult ActionCreate(TOURIS_TV_USER userView)
        {
           TOURIS_TV_USER userRes = new TOURIS_TV_USER();

            userRes = JsonConvert.DeserializeObject<TOURIS_TV_USER>(ParsingObject.JsonData(userView, "User", "InsertObjUser"));
            return View(userRes);
        }

        [AllowAnonymous]
        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult ActionEdit(TOURIS_TV_USER userView)
        {
            TOURIS_TV_USER userRes = new TOURIS_TV_USER();

            userRes = JsonConvert.DeserializeObject<TOURIS_TV_USER>(ParsingObject.JsonData(userView, "User", "EditObjUser"));
            return View(userRes);
        }

        [AllowAnonymous]
        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult ActionDelete(TOURIS_TV_USER userView)
        {
            TOURIS_TV_USER userRes = new TOURIS_TV_USER();

            userRes = JsonConvert.DeserializeObject<TOURIS_TV_USER>(ParsingObject.JsonData(userView, "User", "DeleteObjUser"));
            return View(userRes);
        }

    }
}