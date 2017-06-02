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
            int it = 0;
            double x = ValStarta;
            double aux=0;
            double fx=0;
            double dfx=0;

            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            string[] IterationVals = new string[6];

            IterationVals[0] = Convert.ToString(it);
            IterationVals[1] = Convert.ToString(aux);
            IterationVals[2] = Convert.ToString(fx);
            IterationVals[3] = Convert.ToString(dfx);
            IterationVals[4] = Convert.ToString(x);
            IterationVals[5] = Convert.ToString(aux - x);
            Resultado.AddLast(IterationVals);
            it++;
            do
            {
                aux = x;


                fx = Math.Round(funcion(this.Expresion, x), 7);
                dfx = Math.Round(funcion(this.Derivate, x), 7);


                x = Math.Round(x - (fx / dfx), 7);

                IterationVals = new string[6];

                IterationVals[0] = Convert.ToString(it);
                IterationVals[1] = Convert.ToString(aux);
                IterationVals[2] = Convert.ToString(fx);
                IterationVals[3] = Convert.ToString(dfx);
                IterationVals[4] = Convert.ToString(x);
                IterationVals[5] = Convert.ToString(aux - x);
                Resultado.AddLast(IterationVals);

                it++;

            } while (it <= Iteration && Math.Abs(aux-x) > Tolerance);

            Root = x;

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
