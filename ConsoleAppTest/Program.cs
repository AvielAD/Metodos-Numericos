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
            string expre = "2 0 -3 3 -4";
            Horner h = new Horner(expre, -2, 5);
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
