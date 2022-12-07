using Avaliacao.Models;
using Avaliacao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avaliacao.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        [HttpGet]
        public ActionResult Index()
        {
            NumberModel _numbermodel = new NumberModel();
            return View(_numbermodel);
        }
        [HttpPost]

        public ActionResult Index(NumberModel numbers)
        {
            if (numbers.Operacao == "+")
                return RedirectToAction("Somar", new { numbers.Num1, numbers.Num2 });
            if (numbers.Operacao == "-")
                return RedirectToAction("Subtrair", new { numbers.Num1, numbers.Num2 });
            if (numbers.Operacao == "/")
                return RedirectToAction("Dividir", new { numbers.Num1, numbers.Num2 });
            if (numbers.Operacao == "*")
                return RedirectToAction("Multiplicar", new { numbers.Num1, numbers.Num2 });
            
            return View();
        }
        public ActionResult Somar(int num1, int num2)
        {
           int resultado = Calculadora.Calcula().Somar(num1, num2);
            return View(resultado);
        }
        public ActionResult Subtrair(int num1 = 0, int num2 = 0)
        {
            int resultado = Calculadora.Calcula().Subtrair(num1, num2);

            return View(resultado);
        }
        public ActionResult Multiplicar(int num1 = 0, int num2 = 0)
        {
            int resultado = Calculadora.Calcula().Multiplicar(num1, num2);

            return View(resultado);
        }
        public ActionResult Dividir(int num1 = 0, int num2 = 0)
        {
            int resultado = Calculadora.Calcula().Dividir(num1, num2);

            return View(resultado);
        }
    }
}