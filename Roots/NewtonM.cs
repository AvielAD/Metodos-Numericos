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
        public string DerivateTwo { get; set; }
        public double Root { get; set; }
        private Evaluador evaluator;

        public NewtonM()
        {
            evaluator = new Evaluador();
            evaluator.Presition = 7;
        }

        public LinkedList<string[]> solucion()
        {
            int it = 1;
            double x = evaluator.EvalVar(ValStarta);
            double aux = 0;
            double fx = 0;
            double dfx = 0;
            double ddfx = 0;


            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[3];

            do
            {
                aux = x;
                
                fx = evaluator.EvalFunction(Expresion, x);
                dfx = evaluator.EvalFunction(Derivate, x);
                ddfx = evaluator.EvalFunction(DerivateTwo, x);

                x = x - (fx * dfx) / ( dfx * dfx  -  fx * ddfx);

                IterationVals = new string[3];

                IterationVals[0] = Convert.ToString(it);
                IterationVals[1] = Convert.ToString(x);
                IterationVals[2] = Convert.ToString(aux - x);
                Resultado.AddLast(IterationVals);

                it++;

            } while (it <= Iteration && Math.Abs(aux - x) > Tolerance);

            Root = x;

            return Resultado;
        }
    }
}
