using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avaliacao.Services
{
    public class Upload
    {
        private Upload() { }

        private static readonly Upload _instance = new Upload();

        public static Upload GetUpload()
        {
            return _instance;
        }

        public static void SetUpload(HttpPostedFileBase file) {
            var supportedTypes = new[] { "txt" };
                var fileExt = Path.GetExtension(file.FileName).Substring(1);
                if (file.ContentLength > 0)
                {
                    if (supportedTypes.Contains(fileExt))
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                        file.SaveAs(_path);
                    }

                }
        }
    }
}