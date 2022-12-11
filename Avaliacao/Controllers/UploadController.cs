using Avaliacao.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avaliacao.Controllers
{
    public class UploadController : Controller
    {
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            Upload.SetUpload(file);
            return View();

        }
    }
}