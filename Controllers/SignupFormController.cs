

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class SignupFormController : Controller
    {
        //
        // GET: /SignupForm/

        Database1Entities3 db = new Database1Entities3();

        public ActionResult SignupForm()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Reg_User r)
        {
            //if (ModelState.IsValid)
            //{
            //    using (Database1Entities d = new Database1Entities())
            //    {
            //        d.Reg_User.Add(r);
            //        d.SaveChanges();
            //        ModelState.Clear();
            //        r = null;

            //        ViewBag.Message = "Successfully Registered";


            //    }
            //}

            if (!ModelState.IsValid)
            {
                return View("SignupForm");
            }
            else
            {
                db.Reg_User.Add(r);
                //entering data into user login table for LOGIN purpose!!
                User u = new User();
                u.UserName = r.Username;
                u.Password = r.Password;
                u.Role = "User";
                db.Users.Add(u);

                db.SaveChanges();

                return RedirectToAction("Index","Home");
            }
        }
    }
}
