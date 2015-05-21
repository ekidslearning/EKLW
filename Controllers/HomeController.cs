using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities3 db = new Database1Entities3();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["isHideButton"] = true;
            return View(db.Users.ToList());
        }

        public string Address(int id)
        {
            var add = (from u in db.Movies where u.M_Id == id select u.Movie).FirstOrDefault();
            return add;
        }


    }
}
