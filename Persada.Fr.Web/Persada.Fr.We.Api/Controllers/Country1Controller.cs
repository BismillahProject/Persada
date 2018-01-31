using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Persada.Fr.Model;

namespace Persada.Fr.We.Api.Controllers
{
    public class Country1Controller : Controller
    {
        private TourismpediaEntities db = new TourismpediaEntities();

        // GET: Country1
        public ActionResult Index()
        {
            return View(db.TOURIS_TM_COUNTRY.ToList());
        }

        // GET: Country1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOURIS_TM_COUNTRY tOURIS_TM_COUNTRY = db.TOURIS_TM_COUNTRY.Find(id);
            if (tOURIS_TM_COUNTRY == null)
            {
                return HttpNotFound();
            }
            return View(tOURIS_TM_COUNTRY);
        }

        // GET: Country1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Country1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,COUNTRY_NAME,COUNTRY_CODE,COUNTRY_DESCRIPTION,CREATED_TIME,CREATED_BY,LAST_MODIFIED_TIME,LAST_MODIFIED_BY,ROW_STATUS")] TOURIS_TM_COUNTRY tOURIS_TM_COUNTRY)
        {
            if (ModelState.IsValid)
            {
                db.TOURIS_TM_COUNTRY.Add(tOURIS_TM_COUNTRY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tOURIS_TM_COUNTRY);
        }

        // GET: Country1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOURIS_TM_COUNTRY tOURIS_TM_COUNTRY = db.TOURIS_TM_COUNTRY.Find(id);
            if (tOURIS_TM_COUNTRY == null)
            {
                return HttpNotFound();
            }
            return View(tOURIS_TM_COUNTRY);
        }

        // POST: Country1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,COUNTRY_NAME,COUNTRY_CODE,COUNTRY_DESCRIPTION,CREATED_TIME,CREATED_BY,LAST_MODIFIED_TIME,LAST_MODIFIED_BY,ROW_STATUS")] TOURIS_TM_COUNTRY tOURIS_TM_COUNTRY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tOURIS_TM_COUNTRY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tOURIS_TM_COUNTRY);
        }

        // GET: Country1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TOURIS_TM_COUNTRY tOURIS_TM_COUNTRY = db.TOURIS_TM_COUNTRY.Find(id);
            if (tOURIS_TM_COUNTRY == null)
            {
                return HttpNotFound();
            }
            return View(tOURIS_TM_COUNTRY);
        }

        // POST: Country1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TOURIS_TM_COUNTRY tOURIS_TM_COUNTRY = db.TOURIS_TM_COUNTRY.Find(id);
            db.TOURIS_TM_COUNTRY.Remove(tOURIS_TM_COUNTRY);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
