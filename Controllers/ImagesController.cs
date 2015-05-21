using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class ImagesController : Controller
    {
        //
        // GET: /Images/
        Database1Entities3 db = new Database1Entities3();
        public ActionResult Images()
        {
            return View(db.Images.ToList());
        }

    }
}
