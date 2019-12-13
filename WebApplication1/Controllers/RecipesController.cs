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
    public class RecipesController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();

        // GET: Recipes
        public ActionResult Index()
        {
            var recipes1 = db.Recipes1.Include(r => r.User);
            return View(recipes1.ToList());
        }

        // GET: Recipes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipes recipes = db.Recipes1.Find(id);
            if (recipes == null)
            {
                return HttpNotFound();
            }
            return View(recipes);
        }

        // GET: Recipes/Create
        public ActionResult Create()
        {
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name");
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Ingridiants,Details,UsersId")] Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                db.Recipes1.Add(recipes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipes.UsersId);
            return View(recipes);
        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipes recipes = db.Recipes1.Find(id);
            if (recipes == null)
            {
                return HttpNotFound();
            }
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipes.UsersId);
            return View(recipes);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Ingridiants,Details,UsersId")] Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipes.UsersId);
            return View(recipes);
        }

        // GET: Recipes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipes recipes = db.Recipes1.Find(id);
            if (recipes == null)
            {
                return HttpNotFound();
            }
            return View(recipes);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipes recipes = db.Recipes1.Find(id);
            db.Recipes1.Remove(recipes);
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
