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
    public class ContestsController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();

        // GET: Contests
        public ActionResult Index()
        {
            return View(db.Contests1.ToList());
        }

        // GET: Contests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contests contests = db.Contests1.Find(id);
            if (contests == null)
            {
                return HttpNotFound();
            }
            return View(contests);
        }

        // GET: Contests/Create
        [Authorize(Roles ="Admin,SuperAdmin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Create([Bind(Include = "Id,Title,Details,StartDate,EndDate")] Contests contests)
        {
            if(contests.StartDate<DateTime.Now || contests.EndDate<DateTime.Now)
            {
                ModelState.AddModelError("EndDate", "Incorrect Start Date or End Date");
                return View();

            }
            else { 
                if (ModelState.IsValid)
            {
                db.Contests1.Add(contests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contests);
            }
        }

        // GET: Contests/Edit/5
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contests contests = db.Contests1.Find(id);
            if (contests == null)
            {
                return HttpNotFound();
            }
            return View(contests);
        }

        // POST: Contests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Edit([Bind(Include = "Id,Title,Details,StartDate,EndDate")] Contests contests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contests);
        }

        // GET: Contests/Delete/5
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contests contests = db.Contests1.Find(id);
            if (contests == null)
            {
                return HttpNotFound();
            }
            return View(contests);
        }

        // POST: Contests/Delete/5
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contests contests = db.Contests1.Find(id);
            db.Contests1.Remove(contests);
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
