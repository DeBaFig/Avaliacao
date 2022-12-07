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
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            var supportedTypes = new[] { "txt" };
            try
            {
                var fileExt = Path.GetExtension(file.FileName).Substring(1);
                if (file.ContentLength > 0)
                {
                    if (supportedTypes.Contains(fileExt))
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                        file.SaveAs(_path);
                    }
                    else
                    {
                        ViewBag.Message = "Formato de arquivo inválido!!";
                        return View();
                    }

                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}