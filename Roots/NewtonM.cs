using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
namespace Roots
{
    public class NewtonM
    {
        public string ValStarta { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public string Derivate { get; set; }
        public double Root { get; set; }
        private Evaluador evaluator;

        public NewtonM()
        {
            evaluator.Presition = 7;
        }

        public LinkedList<string[]> solucion()
        {
            int it = 1;
            double x = evaluator.EvalVar(ValStarta);
            double aux = 0;
            double fx = 0;
            double dfx = 0;

            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[6];

            do
            {
                aux = x;
                
                fx = evaluator.EvalFunction(Expresion, x);
                dfx = evaluator.EvalFunction(Derivate, x);
                
                x = Math.Round(x - (fx / dfx), 7);

                IterationVals = new string[6];

                IterationVals[0] = Convert.ToString(it);
                IterationVals[4] = Convert.ToString(x);
                IterationVals[1] = Convert.ToString(aux);
                IterationVals[2] = Convert.ToString(fx);
                IterationVals[3] = Convert.ToString(dfx);
                IterationVals[5] = Convert.ToString(aux - x);
                Resultado.AddLast(IterationVals);

                it++;

            } while (it <= Iteration && Math.Abs(aux - x) > Tolerance);

            Root = x;

            return Resultado;
        }
    }
}
