using Roots;
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
            string Coeficientes = "1 0 0 -25";
            double Aproximacion = 2.5;
            double Tolerancia = 0.000001;
            int Iteraciones = 20;

            Horner h = new Horner(Coeficientes, Aproximacion);
            h.HornerMetod(Tolerancia, Iteraciones);

            Console.Write("Coeficientes: ");
            foreach (var item in h.Coeficientes)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Respuesta a raiz aproximada: {0}", h.Root);
            Console.ReadKey();

        }
    }
}
