using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class LoginFormController : Controller
    {

        Database1Entities3 db = new Database1Entities3();
        
        //
        // GET: /LoginForm/

        public ActionResult LoginForm()
        {
            return View();
        }




    }
}
