using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AnnoucmentsController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();

        // GET: Annoucments
        public ActionResult Index()
        {
            return View(db.Annoucments.ToList());
        }

        // GET: Annoucments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annoucments annoucments = db.Annoucments.Find(id);
            if (annoucments == null)
            {
                return HttpNotFound();
            }
            return View(annoucments);
        }

        // GET: Annoucments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Annoucments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Details,Date_Of_Annoucment")] Annoucments annoucments)
        {
            if (ModelState.IsValid)
            {
                db.Annoucments.Add(annoucments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(annoucments);
        }

        // GET: Annoucments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annoucments annoucments = db.Annoucments.Find(id);
            if (annoucments == null)
            {
                return HttpNotFound();
            }
            return View(annoucments);
        }

        // POST: Annoucments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Details,Date_Of_Annoucment")] Annoucments annoucments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(annoucments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(annoucments);
        }

        // GET: Annoucments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annoucments annoucments = db.Annoucments.Find(id);
            if (annoucments == null)
            {
                return HttpNotFound();
            }
            return View(annoucments);
        }

        // POST: Annoucments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Annoucments annoucments = db.Annoucments.Find(id);
            db.Annoucments.Remove(annoucments);
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
