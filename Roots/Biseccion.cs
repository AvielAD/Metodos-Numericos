using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
using System.Collections;
using System.Windows.Forms;

namespace Roots
{
    public class Biseccion
    {

        public double ValStarta { get; set; }
        public double ValStartb { get; set; }
        public double Tolerance { get; set; }
        public int Iteration { get; set; }
        public string Expresion { get; set; }
        public string Derivate { get; set; }
        public double Root { get; set; }

        public Biseccion()
        {
            
        }

        public LinkedList<string[]> solucion()
        {
            double pm;
            double fa;
            double fb;
            double fpm;
            int it = 0;

            
            LinkedList<string[]> Resultado = new LinkedList<string[]>();

            do
            {
                pm = ValStarta +( (ValStartb - ValStarta) / 2);
                fa = funcion(ValStarta);
                fb = funcion(ValStartb);
                fpm = funcion(pm);

                //data.Rows.Add(it, ValStarta, ValStartb, pm, fa, fb, fpm); saludos
                string[] IterationVals = new string[7];

                IterationVals[0] = Convert.ToString(it);
                IterationVals[1] = Convert.ToString(ValStarta);
                IterationVals[2] = Convert.ToString(ValStartb);
                IterationVals[3] = Convert.ToString(pm);
                IterationVals[4] = Convert.ToString(fa);
                IterationVals[5] = Convert.ToString(fb);
                IterationVals[6] = Convert.ToString(fpm);

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
            } while (it <= Iteration && Tolerance < Math.Abs( ((ValStartb-ValStarta)/2) ));

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
    }
}

