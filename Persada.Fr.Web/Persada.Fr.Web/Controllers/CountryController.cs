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
    public class CountryController : Controller
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
            ViewBag.msgSuccess = TempData["msgSuccess"];
            ViewBag.msgError = TempData["msgError"];
            List<TOURIS_TV_COUNTRY> countryRes = new List<TOURIS_TV_COUNTRY>();

            countryRes = JsonConvert.DeserializeObject<List<TOURIS_TV_COUNTRY>>(ParsingObject.JsonData(null, "Country", "RetrieveObjCountryList"));
            return View(countryRes);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult ActionCreate(TOURIS_TV_COUNTRY countryView)
        {
            ResultStatus rs = new ResultStatus();
            try
            {
                countryView.CREATED_BY = CurrentUser.GetCurrentUserId();
                countryView.CREATED_TIME = CurrentUser.GetCurrentDateTime();

                rs = JsonConvert.DeserializeObject<ResultStatus>(ParsingObject.JsonData(countryView, "Country", "InsertObjCountry"));
                if (rs.IsSuccess)
                {
                    rs.SetSuccessStatus("Data has been created successfully");
                    TempData["msgSuccess"] = rs.MessageText;
                }
                else
                {
                    rs.SetErrorStatus("Data failed to created");
                    TempData["msgError"] = rs.MessageText;
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                rs.SetErrorStatus("Data failed to created");
                TempData["msgError"] = rs.MessageText;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            TOURIS_TV_COUNTRY countryView = new TOURIS_TV_COUNTRY();
            TOURIS_TV_COUNTRY countryRes = new TOURIS_TV_COUNTRY();

            countryView.ID = id;

            countryRes = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(ParsingObject.JsonData(countryView, "Country", "RetrieveObjCountry"));
            return View(countryRes);
        }
        public ActionResult ActionEdit(TOURIS_TV_COUNTRY countryView)
        {
            ResultStatus rs = new ResultStatus();
            try
            {
                countryView.LAST_MODIFIED_BY = CurrentUser.GetCurrentUserId();
                countryView.LAST_MODIFIED_TIME = CurrentUser.GetCurrentDateTime();

                rs = JsonConvert.DeserializeObject<ResultStatus>(ParsingObject.JsonData(countryView, "Country", "EditObjCountry"));
                if (rs.IsSuccess)
                {
                    rs.SetSuccessStatus("Data has been edited successfully");
                    TempData["msgSuccess"] = rs.MessageText;
                }
                else
                {
                    rs.SetErrorStatus("Data failed to edited");
                    TempData["msgError"] = rs.MessageText;
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                rs.SetErrorStatus("Data failed to edited");
                TempData["msgError"] = rs.MessageText;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            TOURIS_TV_COUNTRY countryView = new TOURIS_TV_COUNTRY();
            TOURIS_TV_COUNTRY countryRes = new TOURIS_TV_COUNTRY();

            countryView.ID = id;

            countryRes = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(ParsingObject.JsonData(countryView, "Country", "RetrieveObjCountry"));
            return View(countryRes);
        }
        public ActionResult ActionDelete(TOURIS_TV_COUNTRY countryView)
        {
            ResultStatus rs = new ResultStatus();
            try
            {
                rs = JsonConvert.DeserializeObject<ResultStatus>(ParsingObject.JsonData(countryView, "Country", "DeleteObjCountry"));
                if (rs.IsSuccess)
                {
                    rs.SetSuccessStatus("Data has been deleted successfully");
                    TempData["msgSuccess"] = rs.MessageText;
                }
                else
                {
                    rs.SetErrorStatus("Data failed to deleted");
                    TempData["msgError"] = rs.MessageText;
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                rs.SetErrorStatus("Data failed to deleted");
                TempData["msgError"] = rs.MessageText;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            TOURIS_TV_COUNTRY countryView = new TOURIS_TV_COUNTRY();
            TOURIS_TV_COUNTRY countryRes = new TOURIS_TV_COUNTRY();

            countryView.ID = id;

            countryRes = JsonConvert.DeserializeObject<TOURIS_TV_COUNTRY>(ParsingObject.JsonData(countryView, "Country", "RetrieveObjCountry"));
            return View(countryRes);
        }

    }
}