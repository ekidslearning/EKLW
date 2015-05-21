using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class AccountController : Controller
    {
        Database1Entities3 db = new Database1Entities3();
      
        //
        // GET: /Login/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult logout()
        {

            if (Session["loggedin"] != null)
            {
                if (((bool)Session["loggedin"]))
                    Session["loggedin"] = false;
                Session.Remove("loggedin");
            }
            return RedirectToAction("Index", "Home");
        }




        [HttpPost]

        public ActionResult loginconfirm(User u)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                string uname = Request["UserName"];
                string upass = Request["Password"];

                User uu = new User();

                var user1 = "";
                try
                {
                    user1 = (from s in db.Users where s.UserName == uname && s.Password == upass select s.Role).First();
                    
                    
                    uu = db.Users.First(m => m.UserName == uname && m.Password == upass);

                    //if(uu.Role=="Admin")
                    //{
                    //    //return admin view
                    //}
                    //else if(uu.Role=="User")
                    //{

                    //    Session["id"] = uu.U_Id;
                    //    Session["name"] = uu.UserName;
                    //    //return user view(db.users.tolist());
                    //}

                    

                    //int id = int.Parse(Session["id"].ToString());

//                    return View(uu.UserName.ToList());

                }

                catch (System.InvalidOperationException e) { }

                if (user1.ToString().Trim().Equals("Admin"))
                {
                    Session.Add("loggedin", true);
                    Session.Add("UserName", uname);
                    return RedirectToAction("Index", "AdminNew");
                }
                else if (user1.ToString().Trim().Equals("User"))
                {
                    Session.Add("loggedin", true);
                    Session.Add("UserName", uname);
                    Session["Uid"] = uu.U_Id;
                    return RedirectToAction("Parent", "Services");

                }
                else
                {
                    ViewBag.Msg = "User does not exist";
                    return RedirectToAction("Notuser", "Notuser");
                }
            }
        }
    }
}
