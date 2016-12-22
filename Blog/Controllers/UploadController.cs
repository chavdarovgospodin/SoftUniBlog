using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(HttpPostedFileBase file)
        {
            string path = Server.MapPath("~/Files" + file.FileName); // setting location
            file.SaveAs(path); // saving file
            @ViewBag.Path = path; //passing file location to view after uploading

            return View();
        }
    }
}