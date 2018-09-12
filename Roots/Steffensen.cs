using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roots
{
    public class Steffensen
    {
        public string ValStarta { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public double Root { get; set; }
        private Evaluador evaluator;
        public int Presition { get; set; }

        public Steffensen(int Presition)
        {
            evaluator = new Evaluador();
            evaluator.Presition = 7;
            this.Presition = Presition;
        }

        public void Solucion()
        {
            int it = 0;
            double P = 0;
            double P1 = 0;
            double P2 = 0;
            double P0 = Convert.ToDouble(ValStarta);
            double ToleranceLimit = 0;
            do
            {
                P1 = (evaluator.EvalFunction(Expresion, P0));

                P2 = (evaluator.EvalFunction(Expresion, P1));

                P = (P0 - (((P1 - P0)*(P1 - P0))/ (P2 - (2 * P1) + P0)));

                ToleranceLimit = Math.Abs(P-P0);

                Console.Write("Iteracion: {0} Valores: \tP={1} \tP0={2} \tP1={3} \tP2={4} ", it, P, P0, P1, P2);
                Console.WriteLine("Tolerancia Limit= {0}",ToleranceLimit);
                it++;
                P0 = P;
            } while (it < Iteration && ToleranceLimit > this.Tolerance);

            Root = P; 

        }

    }
}
