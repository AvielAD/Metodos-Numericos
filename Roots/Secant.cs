using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace Roots
{
    public class Secant
    {
        public double ValStarta { get; set; }
        public double ValStartb { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public double Root { get; set; }

        public Secant()
        {

        }

        public LinkedList<string[]> solucion()
        {
            int it = 2;
            double qa = 0;
            double qb = 0;
            double p0 = ValStarta;
            double p1 = ValStartb;
            double P;

            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[3];
            qa = Math.Round(funcion(this.Expresion, p0), 7);
            qb = Math.Round(funcion(this.Expresion, p1), 7);
            do
            {

                P = p1 - (qa*(p1 - p0)) / (qa - qb);

                IterationVals = new string[3];
                IterationVals[0] = Convert.ToString(it);
                IterationVals[1] = Convert.ToString(P);
                IterationVals[2] = Convert.ToString(P-qa);

                Resultado.AddLast(IterationVals);

                it++;

                p0 = p1;
                qb = qa;
                p1 = P;
                qb = Math.Round(funcion(this.Expresion, P), 7);
            } while (it <= Iteration && Math.Abs(P-qa) > Tolerance);

            return Resultado;
        }

        public double funcion(string exp, double x)
        {
            ExpressionParser evaluador = new ExpressionParser();
            evaluador.Values.Add("x", x);
            double resultado = evaluador.Parse(exp);
            return Math.Round(resultado, 7);
        }
    }
}
