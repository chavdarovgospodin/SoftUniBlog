using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TastyCakes.Models;

namespace TastyCakes.Controllers
{
    public class CakesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Cakes/
        public ActionResult Index()
        {
            return View(db.Cakes.ToList());
        }

        // GET: /Product-5
        public ActionResult Details(int? id)
        {
            ...
        }

        // GET: /Cakes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Cakes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(
        Include = "CakesID,Name,Description,Price")] Cakes cakes)
        {
            ...
        }

        // GET: /Cakes/Edit/5
        public ActionResult Edit(int? id)
        {
            ...
        }

        // POST: /Cakes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(
        Include = "CakesID,Name,Description,Price")] Cakes cakes)
        {
           ...
        }

        // GET: /Cakes/Delete/5
        public ActionResult Delete(int? id)
        {
            ...
        }

        // POST: /Cakes/Delete/5
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ...
        }

        [HttpPost]
        public ActionResult UploadPhoto(string cakesImage,
        HttpPostedFileBase photo)
        {
            string path = @"C:\YourProjectFolders\TastyCakes\Images\Cakes\"
            + cakesImage;

            if (photo != null)
                photo.SaveAs(path);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePhoto(string photoFileName)
        {
            //Session["DeleteSuccess"] = "No";
            var photoName = "";
            photoName = photoFileName;
            string fullPath = Request.MapPath("~/Images/Cakes/"
            + photoName);

            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
                //Session["DeleteSuccess"] = "Yes";
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            ...
        }
    }
}