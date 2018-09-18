using RootsClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = "x^3-x^2-14";
            double valx =2;
            Evaluador eval = new Evaluador();

            Console.WriteLine("Funcion: {0} Resultado: {1}",function, eval.EvalFunction(function,valx));
            Console.ReadKey();
        }
    }
}
