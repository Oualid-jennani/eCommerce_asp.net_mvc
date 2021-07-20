using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eCommerce;

namespace eCommerce.Controllers
{
    public class EordersController : Controller
    {
        private eComEntities db = new eComEntities();
       
        // GET: Eorders
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("/Login/Index");
            }

            //----------------------------------------------------------------------------------------
            if (Request.Params.Get("Search") != null && Request.Params.Get("Search").ToString() != "")
            {
                List<Eorder> list = new List<Eorder>();
                foreach (var O in db.Eorder.ToList())
                {
                    if (O.client.firstName.ToString() == Request.Params.Get("Search").ToString())
                    {
                        list.Add(O);
                    }
                }

                return View(list);
            }
            else
            {
                var eorder = db.Eorder.Include(e => e.client);
                return View(eorder.ToList());
            }
            //----------------------------------------------------------------------------------------

        }

        // GET: Eorders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eorder eorder = db.Eorder.Find(id);
            if (eorder == null)
            {
                return HttpNotFound();
            }
            return View(eorder);
        }

        // GET: Eorders/Create
        public ActionResult Create()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("/Login/Index");
            }


            ViewBag.clientid = new SelectList(db.client, "id", "firstName");
            return View();
        }

        // POST: Eorders/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,clientid,dateorder")] Eorder eorder)
        {
            if (ModelState.IsValid)
            {
                db.Eorder.Add(eorder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.clientid = new SelectList(db.client, "id", "firstName", eorder.clientid);
            return View(eorder);
        }

        // GET: Eorders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eorder eorder = db.Eorder.Find(id);
            if (eorder == null)
            {
                return HttpNotFound();
            }
            ViewBag.clientid = new SelectList(db.client, "id", "firstName", eorder.clientid);
            return View(eorder);
        }

        // POST: Eorders/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,clientid,dateorder")] Eorder eorder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eorder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.clientid = new SelectList(db.client, "id", "firstName", eorder.clientid);
            return View(eorder);
        }

        // GET: Eorders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eorder eorder = db.Eorder.Find(id);
            if (eorder == null)
            {
                return HttpNotFound();
            }
            return View(eorder);
        }

        // POST: Eorders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Eorder eorder = db.Eorder.Find(id);
            db.Eorder.Remove(eorder);
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
