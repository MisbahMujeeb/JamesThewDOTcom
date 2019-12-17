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
    public class Recipe_FeedbackController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();

        // GET: Recipe_Feedback
        public ActionResult Index()
        {
            var recipe_Feedback = db.Recipe_Feedback.Include(r => r.Recipe).Include(r => r.User);
            return View(recipe_Feedback.ToList());
        }

        // GET: Recipe_Feedback/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe_Feedback recipe_Feedback = db.Recipe_Feedback.Find(id);
            if (recipe_Feedback == null)
            {
                return HttpNotFound();
            }
            return View(recipe_Feedback);
        }

        // GET: Recipe_Feedback/Create
        public ActionResult Create()
        {
            ViewBag.RecipesId = new SelectList(db.Recipes1, "Id", "Title");
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name");
            return View();
        }

        // POST: Recipe_Feedback/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RecipeFeedback,RecipesId,UsersId")] Recipe_Feedback recipe_Feedback)
        {
            if (ModelState.IsValid)
            {
                db.Recipe_Feedback.Add(recipe_Feedback);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RecipesId = new SelectList(db.Recipes1, "Id", "Title", recipe_Feedback.RecipesId);
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipe_Feedback.UsersId);
            return View(recipe_Feedback);
        }

        // GET: Recipe_Feedback/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe_Feedback recipe_Feedback = db.Recipe_Feedback.Find(id);
            if (recipe_Feedback == null)
            {
                return HttpNotFound();
            }
            ViewBag.RecipesId = new SelectList(db.Recipes1, "Id", "Title", recipe_Feedback.RecipesId);
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipe_Feedback.UsersId);
            return View(recipe_Feedback);
        }

        // POST: Recipe_Feedback/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RecipeFeedback,RecipesId,UsersId")] Recipe_Feedback recipe_Feedback)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe_Feedback).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RecipesId = new SelectList(db.Recipes1, "Id", "Title", recipe_Feedback.RecipesId);
            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipe_Feedback.UsersId);
            return View(recipe_Feedback);
        }

        // GET: Recipe_Feedback/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe_Feedback recipe_Feedback = db.Recipe_Feedback.Find(id);
            if (recipe_Feedback == null)
            {
                return HttpNotFound();
            }
            return View(recipe_Feedback);
        }

        // POST: Recipe_Feedback/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe_Feedback recipe_Feedback = db.Recipe_Feedback.Find(id);
            db.Recipe_Feedback.Remove(recipe_Feedback);
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
















