using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roots
{
    public class FixedPoint
    {
        public string ValStarta { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public double Root { get; set; }
        private Evaluador evaluator;

        public FixedPoint()
        {
            evaluator = new Evaluador();
            evaluator.Presition = 7;
        }

        public LinkedList<string[]> solucion()
        {
            int it = 0;
            double x = evaluator.EvalVar(ValStarta);
            double x0 = 0.0;
            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[3];

            do
            {


                IterationVals = new string[5];

                IterationVals[0] = Convert.ToString(it);

                IterationVals[1] = Convert.ToString(x);

                IterationVals[2] = Convert.ToString(x0);

                x0 = evaluator.EvalFunction(Expresion, x);

                IterationVals[3] = Convert.ToString(x0);

                IterationVals[4] = Convert.ToString(Math.Abs(x - x0));

                Resultado.AddLast(IterationVals);


                if (Math.Abs(x-x0)<=Tolerance)
                {
                    Root = x;

                    break;
                }

                it++;
                x = x0;

            } while (it <= Iteration );

            Root = -1;


            return Resultado;

        }
    }
}