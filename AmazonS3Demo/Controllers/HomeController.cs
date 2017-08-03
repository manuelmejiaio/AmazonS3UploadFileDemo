using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonS3Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AmazonS3Uploader amazonS3 = new AmazonS3Uploader();

            amazonS3.UploadFile();
            return View();
        }
    }
}