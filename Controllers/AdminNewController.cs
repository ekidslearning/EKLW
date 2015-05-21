using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class AdminNewController : Controller
    {
        private Database1Entities3 db = new Database1Entities3();

        //
        // GET: /AdminNew/

        public ActionResult Update(int id)
        {
            User u = db.Users.Find(id);
            return View(u);
        }
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult Admin_View_Images()
        {
            return View(db.Images.ToList());
        }

        public ActionResult Admin_View_Movies()
        {
            return View(db.Movies.ToList());
        }
        public ActionResult Admin_View_Arts()
        {
            return View(db.Arts.ToList());
        }
        public ActionResult Admin_View_Eng()
        {
            return View(db.Englishes.ToList());
        }
        public ActionResult Admin_View_GK()
        {
            return View(db.GKs.ToList());
        }
        public ActionResult Admin_View_Maths()
        {
            return View(db.Mathematics.ToList());
        }
        //public ActionResult Update(int id)
        //{
        //    User u = db.Users.Find(id);
        //    return View(u);
        //}


        //public ActionResult UpdateImageConfirm(int id)
        //{
        //    Image i = db.Images.Find(id);

        //}
        public ActionResult DeleteMaths(int id)
        {
            Mathematic i = db.Mathematics.Find(id);
            db.Mathematics.Remove(i);
            db.SaveChanges();
            return RedirectToAction("Admin_View_Maths");

        }
        public ActionResult DeleteImage(int id)
        {
            Image i = db.Images.Find(id);
            db.Images.Remove(i);
            db.SaveChanges();
            return RedirectToAction("Admin_View_Images");

        }
        public ActionResult DeleteGK(int id)
        {
            GK i = db.GKs.Find(id);
            db.GKs.Remove(i);
            db.SaveChanges();
            return RedirectToAction("Admin_View_GK");

        }
        public ActionResult DeleteEng(int id)
        {
            English i = db.Englishes.Find(id);
            db.Englishes.Remove(i);
            db.SaveChanges();
            return RedirectToAction("Admin_View_Eng");

        }
        public ActionResult DeleteMovie(int id)
        {
            Movy m = db.Movies.Find(id);
            db.Movies.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Admin_View_Movies");
        }
        public ActionResult DeleteArts(int id)
        {
            Art m = db.Arts.Find(id);
            db.Arts.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Admin_View_Arts");
        }
        public ActionResult UploadImage(int id)
        {
            return View();
        }

        public ActionResult UpdateConfirm(int id)
        {
            User s = db.Users.Find(id);
            string uname = Request["u"];
            string pass = Request["p"];
            string role = Request["r"];

            s.UserName = uname;
            s.Password = pass;
            s.Role = role;
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    
        public ActionResult DeleteNew(int id)
        {
            User s = db.Users.Find(id);
            db.Users.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");



        }

        //
        // GET: /AdminNew/Details/5

        public ActionResult Details(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // GET: /AdminNew/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AdminNew/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /AdminNew/Edit/5

        public ActionResult Edit(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /AdminNew/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /AdminNew/Delete/5

        public ActionResult Delete(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /AdminNew/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}