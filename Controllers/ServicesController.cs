using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class ServicesController : Controller
    {
        //
        // GET: /Services/
        Database1Entities3 db = new Database1Entities3();

        public ActionResult Parent()
        {
            return View(db.Users.ToList());
        }

        public ActionResult Update(int id)
        {
            User u = db.Users.Find(id);
            return View(u);
        }

        public ActionResult UpdateConfirm(int id)
        {
            User s = db.Users.Find(id);
            string uname = Request["UserName"];
            string pass = Request["Password"];
          
            s.UserName = uname;
            s.Password = pass;
           
            db.SaveChanges();
            return RedirectToAction("Parent");


        }
    }
}
