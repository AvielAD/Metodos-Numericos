using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roots
{
    public class Horner
    {
        public double Root { get; set; }
        public string Pattern { get; set; } = "\b";
        public double Aprox { get; set; }
        public int Iterations { get; set; }
        public double Tolerance { get; set; }
        public double [] Coeficientes { get; set; }
        public LinkedList<double []> Operations { get; set; }
        Evaluador Eval = new Evaluador();

        public Horner(string Expression, double Aprox)
        {
            Coeficientes = Eval.Coeficientes(Expression);
            this.Aprox = Aprox;
            Operations = new LinkedList<double[]>();

        }

        public Horner(string Expression, double Aprox, int Iterations, double Tolerance)
        {
            Coeficientes = Eval.Coeficientes(Expression);
            this.Aprox = Aprox;
            this.Iterations = Iterations;
            Operations = new LinkedList<double[]>();
            this.Tolerance = Tolerance;
            
        }

        public double HornerRes(double [] Coefs, double aprox)
        {
            double resultado = 0;
            double P_Aprox = 0;
            double Q_Aprox = 0;
            double[] Aux_Coefs = new double[Coefs.Length];

            Array.Copy(Coefs, Aux_Coefs, Coefs.Length);

            for (int i = 0; i < Coefs.Length; i++)
            {
                resultado = resultado * aprox + Coefs[i];
                Aux_Coefs[i] = resultado;
            }

            P_Aprox = resultado;
            resultado = 0;
            Operations.AddLast(Coefs);

            for (int i = 0; i < Aux_Coefs.Length - 1; i++)
            {
                resultado = resultado * aprox + Aux_Coefs[i];
            }

            Q_Aprox = resultado;
            Operations.AddLast(Aux_Coefs);

            return aprox - (P_Aprox/Q_Aprox);
        }

        public double HornerMetod(double Tolerance,int Iterations)
        {
            int i = 0;
            double Aproximation = this.Aprox;
            double Aproximation_Aux = 0;
            this.Iterations = Iterations;
            do
            {
                Aproximation_Aux = Aproximation;

                Aproximation = HornerRes(Coeficientes,Aproximation);
                i++;
            } while (i<Iterations && Math.Abs(Aproximation_Aux-Aproximation)>Tolerance);

            this.Root = Aproximation;

            return Aproximation;
        }

    }

}
