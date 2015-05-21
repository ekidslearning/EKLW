using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class MoviesController : Controller
    {
        //
        Database1Entities3 db = new Database1Entities3();
        // GET: /Movies/

        public ActionResult Movies()
        {
            return View(db.Movies.ToList());
        }

    }
}
