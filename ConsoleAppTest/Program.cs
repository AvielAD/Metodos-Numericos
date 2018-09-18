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
            string Expression = "x-(x^3-25)/(3x^2)";
            string Aproximacion = "2.5";
            double Tolerancia = 0.000001;
            int Iteraciones = 20;

            Steffensen st = new Steffensen(5);

            st.Expresion = Expression;
            st.ValStarta = Aproximacion;
            st.Iteration = Iteraciones;
            st.Tolerance = Tolerancia;
            st.Solucion();

            Console.WriteLine("Resultado Root aproximada: {0}",st.Root);
            Console.ReadKey();

        }
    }
}
