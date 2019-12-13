using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private JamesThewDOTcomEntities db = new JamesThewDOTcomEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            using (var context = new JamesThewDOTcomEntities())
            {
                bool isValid = context.Users.Any(x => x.User_Name == login.User_Name && x.Password == login.Password);
                if (isValid)
                {
                    Session["UserName"] = login.User_Name;
                    Session["UserId"] = db.Users
                 .Where(m => m.User_Name == login.User_Name&& m.Password == login.Password).SingleOrDefault().Id;
                    return Redirect("/Home/index");
                }
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }
    }
}