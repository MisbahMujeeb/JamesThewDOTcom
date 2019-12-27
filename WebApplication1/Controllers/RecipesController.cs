using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
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
        public ActionResult Index(string searchRecipe)
        {
            ViewBag.search = searchRecipe;
            if (searchRecipe == null)
            {
                if (Session["UserId"] == null||User.Identity.IsAuthenticated==false)
                {
                    var f = db.Recipes1.Where(x => x.FreeOrPaid == "Free").ToList();
                    return View(f);
                }
                else { 
                return View(db.Recipes1.ToList());
                }
            }
            else
            {
                if (Session["UserId"] == null || User.Identity.IsAuthenticated == false)
                {
                    return View(db.Recipes1.Where(x => x.Title.Contains(searchRecipe)&& x.FreeOrPaid == "Free").ToList());
                }else {
                    return View(db.Recipes1.Where(x => x.Title.Contains(searchRecipe)).ToList());
                }
            }
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
        [Authorize]
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
        [Authorize]
        public ActionResult Create(Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(recipes.ImageFile.FileName);
                string extention = Path.GetExtension(recipes.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("hhmmssfff") + extention;
                recipes.ImagePath = "Images/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                recipes.ImageFile.SaveAs(fileName);

                db.Recipes1.Add(recipes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsersId = new SelectList(db.Users, "Id", "User_Name", recipes.UsersId);
            return View(recipes);
        }

        // GET: Recipes/Edit/5
        [Authorize]
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
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Title,Ingridiants,Details,UsersId,ImagePath,FreeOrPaid")] Recipes recipes)
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
        [Authorize]
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






//public HttpPostedFileBase ImageFile { get; set; }