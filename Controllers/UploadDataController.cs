using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class UploadDataController : Controller
    {
        Database1Entities3 db = new Database1Entities3();
        //
        // GET: /UploadData/

        public ActionResult UploadData()
        {
            if (Session["loggedin"] != null)
            {
                if (((bool)Session["loggedin"]))
                    return View(db.Movies.ToList());
            }
            return RedirectToAction("Notuser", "Notuser");
        }
        [HttpPost]

        public ActionResult Upload()
        {
            Movy m = new Movy();

            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                string mov = @"~\Movies\" + file.FileName;
                m.Movie = @"/Movies/" + file.FileName;
                db.Movies.Add(m);
                db.SaveChanges();
                file.SaveAs(Server.MapPath(mov));
            }
            return RedirectToAction("UploadData", "UploadData");
        }

        public ActionResult UploadImages()
        {
            Image im = new Image();
            try
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase file = Request.Files[i];
                    string img = @"~\ImageTable\" + file.FileName;
                    im.Image1 = @"/ImageTable/" + file.FileName;
                    db.Images.Add(im);
                    db.SaveChanges();
                    file.SaveAs(Server.MapPath(img));
                }
            }
            catch (System.IO.DirectoryNotFoundException e) { }
            return RedirectToAction("UploadData", "UploadData");
        }

        public ActionResult UploadEnglish()
        {
            English e = new English();
            string name = Request["name"];
            e.E_filename = name;
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                string mov = @"~\English\" + file.FileName;
                e.E_file = @"/English/" + file.FileName;
                db.Englishes.Add(e);
                db.SaveChanges();
                file.SaveAs(Server.MapPath(mov));
            }
            
            db.SaveChanges();
            return RedirectToAction("UploadData", "UploadData");

        }
        public ActionResult UploadArts()
        {
            Art e = new Art();
            string name = Request["name"];
            e.A_filename = name;
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                string mov = @"~\Arts\" + file.FileName;
                e.A_file = @"/Arts/" + file.FileName;
                db.Arts.Add(e);
                db.SaveChanges();
                file.SaveAs(Server.MapPath(mov));
            }

            db.SaveChanges();
            return RedirectToAction("UploadData", "UploadData");

        }

        public ActionResult UploadGK()
        {
            GK e = new GK();
            string name = Request["name"];
            e.GK_filename = name;
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                string mov = @"~\GK\" + file.FileName;
                e.GK_file = @"/GK/" + file.FileName;
                db.GKs.Add(e);
                db.SaveChanges();
                file.SaveAs(Server.MapPath(mov));
            }

            db.SaveChanges();
            return RedirectToAction("UploadData", "UploadData");

        }
        public ActionResult UploadMaths()
        {
            Mathematic e = new Mathematic();
           
            string name = Request["name"];
            e.Ma_filename = name;
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                string mov = @"~\Math\" + file.FileName;
                e.Ma_file = @"/Math/" + file.FileName;
                db.Mathematics.Add(e);
                db.SaveChanges();
                file.SaveAs(Server.MapPath(mov));
            }

            db.SaveChanges();
            return RedirectToAction("UploadData", "UploadData");

        }
    }
}
