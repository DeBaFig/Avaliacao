using Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avaliacao.Controllers
{
    public class ArquivosController : Controller
    {
        // GET: Arquivos
        public ActionResult Index()
        {
            int i = 1;
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/UploadedFiles/"));
            List<FileModel> FileList = new List<FileModel>();
            foreach (string filePath in filePaths)

            {
                FileList.Add(new FileModel
                {
                    FileId = i++,
                    FileName = Path.GetFileName(filePath),
                });
            }
            return View(FileList);
        }
        [HttpGet]
        public ActionResult Detalhes(string fileName)
        {
            string path = Server.MapPath("~/UploadedFiles/") + fileName;
            string[] Lines = System.IO.File.ReadAllLines(path);

            //bubblesort
            string temp;
            for (int j = 0; j <= Lines.Length - 2; j++)
            {
                for (int i = 0; i <= Lines.Length - 2; i++)
                {
                    if (Lines[i].CompareTo(Lines[i + 1]) == 1)
                    {
                        temp = Lines[i + 1];
                        Lines[ i + 1 ] = Lines[i];
                        Lines[i] = temp;
                    }
                }
            }
            ViewBag.Lines = Lines;
            return View();
        }
    }
}