using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RootsClassLibrary
{
    public class Biseccion
    {

        public string ValStarta1 { get; set; }
        public string ValStartb1 { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public double Root { get; set; }
        private Evaluador evaluator;

        public Biseccion()
        {
            evaluator = new Evaluador();
            evaluator.Presition = 5;
        }

        public LinkedList<string[]> Solucion()
        {
            double ValStarta=Convert.ToDouble(ValStarta1);
            double ValStartb=Convert.ToDouble(ValStartb1);
            double pm;
            double fa;
            double fb;
            double fpm=1000;
            int it = 0;

            
            LinkedList<string[]> Resultado = new LinkedList<string[]>();
            string[] IterationVals;
            do 
            {
                pm = ( (ValStartb + ValStarta) / 2);
                fa = evaluator.EvalFunction(Expresion, ValStarta);
                fb = evaluator.EvalFunction(Expresion, ValStartb);
                fpm = evaluator.EvalFunction(Expresion, pm);

                IterationVals = new string[8];
                IterationVals[0] = Convert.ToString(it);
                IterationVals[1] = Convert.ToString(ValStarta);
                IterationVals[2] = Convert.ToString(ValStartb);
                IterationVals[3] = Convert.ToString(pm);
                IterationVals[4] = Convert.ToString(fa);
                IterationVals[5] = Convert.ToString(fb);
                IterationVals[6] = Convert.ToString(fpm);
                IterationVals[7] = Convert.ToString(ValStartb-ValStarta);

                Resultado.AddLast(IterationVals);

                if (fpm * fa < 0)
                {
                    ValStartb = pm;
                }
                else if(fpm * fb < 0)
                {
                    ValStarta = pm;
                }
                else
                {
                    pm = -1;
                    break;
                }

                it++;

            } while (Math.Abs(ValStartb-ValStarta) >= Tolerance && it < Iteration);

            Root = pm;

            return Resultado;
        }
    }
}

