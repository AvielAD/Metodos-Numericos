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
            string Coeficientes = "2 0 -3 3 -4";
            double Aproximacion = -2;
            int Iteraciones = 5;

            Horner h = new Horner(Coeficientes, Aproximacion, Iteraciones);
            h.HornerMetod();

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
