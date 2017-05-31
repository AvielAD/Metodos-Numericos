using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace Roots
{
    public class Newton
    {
        public double ValStarta { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public string Derivate { get; set; }
        public double Root { get; set; }

        public Newton()
        {

        }

        public LinkedList<string[]> solucion()
        {
            double pm;
            int it = 0;


            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            do
            {
                pm = (ValStarta - funcion(ValStarta)) / funcion_derivate(ValStarta);

                string[] IterationVals = new string[7];

                IterationVals[0] = Convert.ToString(it);

                IterationVals[1] = Convert.ToString(ValStarta);

                Resultado.AddLast(IterationVals);

                ValStarta = pm;

                it++;
            } while (it <= Iteration && (pm - ValStarta) < Tolerance);

            Root = pm;

            return Resultado;
        }

        public double funcion(double x)
        {
            ExpressionParser evaluador = new ExpressionParser();
            evaluador.Values.Add("x", x);
            double resultado = evaluador.Parse(this.Expresion);
            return Math.Round(resultado, 7);
        }

        public double funcion_derivate(double x)
        {
            ExpressionParser evaluador = new ExpressionParser();
            evaluador.Values.Add("x", x);
            double resultado = evaluador.Parse(this.Expresion);
            return Math.Round(resultado, 7);
        }
    }
}
