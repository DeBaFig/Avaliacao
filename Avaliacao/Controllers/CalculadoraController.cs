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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Somar(int num1=0, int num2=0)
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