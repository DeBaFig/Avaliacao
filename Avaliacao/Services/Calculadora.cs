using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avaliacao.Services
{
    public class Calculadora : ICalculadora
    {
        private Calculadora() { }

        private static readonly Calculadora _instance = new Calculadora();

        public static Calculadora Calcula()
        {  
            return _instance; 
        }

        public int Dividir(int num1, int num2)
        {
            if(num2 < 0)
            {
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1* num2;
        }

        public int Somar(int num1, int num2)
        {
           return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
           return num1 - num2;
        }
    }
}