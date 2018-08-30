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
        private Evaluador evaluator;

        public Secant()
        {
            evaluator = new Evaluador();
            evaluator.Presition = 7;
        }

        public LinkedList<string[]> solucion()
        {
            int it = 2;
            double q0 = 0;
            double q1 = 0;
            double p0 = evaluator.EvalVar(ValStarta);
            double P;
            double p1 = evaluator.EvalVar(ValStartb);

            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[3];
            q0 = evaluator.EvalFunction(Expresion, p0);
            q1 = evaluator.EvalFunction(Expresion, p1);

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
                q1 = evaluator.EvalFunction(Expresion, P);

            } while (it <= Iteration && Math.Abs(P-p1) < Tolerance);

            Root = P;

            return Resultado;
        }
    }
}
