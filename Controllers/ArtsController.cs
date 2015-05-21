using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class ArtsController : Controller
    {
        //
        Database1Entities3 db = new Database1Entities3();
      
        // GET: /Arts/

        public ActionResult Arts()
        {
            if (Session["loggedin"] != null)
            {
                if (((bool)Session["loggedin"]))
                    return View(db.Arts.ToList()) ;
            }
            return RedirectToAction("Notuser", "Notuser");
       
        }

    }
}
