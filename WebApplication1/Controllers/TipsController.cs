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
    public class TipsController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();

        // GET: Tips
        public ActionResult Index(string searchTips)
        {
            ViewBag.searchTips = searchTips;
            if (searchTips == null)
            {
                return View(db.Tips.ToList());
            }
            else
            {
                return View(db.Tips.Where(x => x.Title.Contains(searchTips)).ToList());

            }
        }

        // GET: Tips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tips tips = db.Tips.Find(id);
            if (tips == null)
            {
                return HttpNotFound();
            }
            return View(tips);
        }

        // GET: Tips/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name");
            return View();
        }

        // POST: Tips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,Title,Details,UsersId")] Tips tips)
        {
            if (ModelState.IsValid)
            {
                db.Tips.Add(tips);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", tips.UsersId);
            return View(tips);
        }

        // GET: Tips/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tips tips = db.Tips.Find(id);
            if (tips == null)
            {
                return HttpNotFound();
            }
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", tips.UsersId);
            return View(tips);
        }

        // POST: Tips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Title,Details,UsersId")] Tips tips)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tips).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", tips.UsersId);
            return View(tips);
        }

        // GET: Tips/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tips tips = db.Tips.Find(id);
            if (tips == null)
            {
                return HttpNotFound();
            }
            return View(tips);
        }

        // POST: Tips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Tips tips = db.Tips.Find(id);
            db.Tips.Remove(tips);
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
