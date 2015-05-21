using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class EnglishController : Controller
    {
        //
        // GET: /English/
        Database1Entities3 db = new Database1Entities3();
      
        public ActionResult English()
        {
            if(Session["loggedin"]!=null)
            {
                if(((bool)Session["loggedin"]))
                    return View(db.Englishes.ToList());
            }
            return RedirectToAction("Notuser", "Notuser");
        }

    }
}
