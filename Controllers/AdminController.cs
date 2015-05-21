using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class AdminController : Controller
    {
        Database1Entities3 db = new Database1Entities3();
        //
        // GET: /Admin/

        public ActionResult Admin_Index()
        {
            return View(db.Users.ToList());
        }
        public ActionResult updateconfirm(User ss)
        {
            var s = db.Users.First(x => x.U_Id == ss.U_Id);
            s.UserName = ss.UserName;
            s.Password = ss.Password;
            db.SaveChanges();
            return RedirectToAction("Changed", "Admin");

        }
        public ActionResult Update(int id)
        {
            User s = db.Users.First(x => x.U_Id == id);

            return View(s);


        }
        
    }
}
