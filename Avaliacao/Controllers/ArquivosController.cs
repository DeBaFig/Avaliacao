using Avaliacao.Models;
using Avaliacao.Services;
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
            return View(Arquivos.GetArquivos());
        }
        [HttpGet]
        public ActionResult Detalhes(string fileName)
        {
            ViewBag.Lines = Arquivos.ReadArquivos(fileName);
            return View();
        }
    }
}