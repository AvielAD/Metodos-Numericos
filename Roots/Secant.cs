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
        public string ValStarta { get; set; }
        public string ValStartb { get; set; }
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
            double q0 = 0;
            double q1 = 0;
            double p0 = this.funcion(ValStarta, 0);
            double P;
            double p1 = this.funcion(ValStartb, 0);

            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[3];
            q0 = Math.Round(funcion(this.Expresion, p0), 7);
            q1 = Math.Round(funcion(this.Expresion, p1), 7);

            do
            {

                P = p1 - q1*(p1 - p0) / (q1 - q0);

                IterationVals = new string[3];
                IterationVals[0] = Convert.ToString(it);
                IterationVals[1] = Convert.ToString(P);
                IterationVals[2] = Convert.ToString(Math.Abs(P-p1));

                Resultado.AddLast(IterationVals);

                it++;

                p0 = p1;
                q0 = q1;
                p1 = P;
                q1 = Math.Round(funcion(this.Expresion, P), 7);
            } while (it <= Iteration && Math.Abs(P-p1) < Tolerance);

            Root = P;

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
