using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();

        // GET: Users
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Role).Include(u => u.Subscription_Type);
            return View(users.ToList());
        }

        // GET: Users/Details/5
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Details(int? id )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.Role_id = new SelectList(db.Roles, "id", "Role_name");
            ViewBag.Subscription_Type_id = new SelectList(db.Subscription_Type, "id", "Sub_Type");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,User_Name,Email,Password,Role_id,Subscription_Type_id")] Users users)
        {
            var ids = db.Roles
                 .Where(m => m.Role_name == "User" ).SingleOrDefault().id;
            ViewBag.roleid = ids;

            if (ModelState.IsValid)
            {
                db.Users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        
            //ViewBag.Role_id = new SelectList(db.Roles, "id", "Role_name", users.Role_id);
            ViewBag.Subscription_Type_id = new SelectList(db.Subscription_Type, "id", "Sub_Type", users.Subscription_Type_id);
            return View(users);
        }

        // GET: Users/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            ViewBag.Role_id = new SelectList(db.Roles, "id", "Role_name", users.Role_id);
            ViewBag.Subscription_Type_id = new SelectList(db.Subscription_Type, "id", "Sub_Type", users.Subscription_Type_id);
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Users users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("profile");
            }
            ViewBag.Role_id = new SelectList(db.Roles, "id", "Role_name", users.Role_id);
            ViewBag.Subscription_Type_id = new SelectList(db.Subscription_Type, "id", "Sub_Type", users.Subscription_Type_id);
            return View(users);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Users users = db.Users.Find(id);
            db.Users.Remove(users);
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
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();
            return Redirect("/home/index");
        }
        public ActionResult profile()
        {
            var Pid = Session["UserId"];
            if (Pid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(Pid);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }


    }
}
