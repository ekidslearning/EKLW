using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class MathsController : Controller
    {
        //
        // GET: /Maths/
        Database1Entities3 db = new Database1Entities3();
        public ActionResult Maths()
        {
            if (Session["loggedin"] != null)
            {
                if (((bool)Session["loggedin"]))
                    return View(db.Mathematics.ToList());
            }
            return RedirectToAction("Notuser", "Notuser");
       
        }

    }
}
