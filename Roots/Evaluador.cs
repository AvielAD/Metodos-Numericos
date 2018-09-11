using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using info.lundin.math;
namespace Roots
{
    public class Evaluador
    {
        public int Presition { get; set; }

        public Evaluador()
        {

        }

        public double EvalFunction(string Expresion, double Val)
        {

            ExpressionParser evaluador = new ExpressionParser();
            evaluador.Values.Add("x", Val);
            double resultado = evaluador.Parse(Expresion);
            return Math.Round(resultado, Presition);

        }

        public double [] Coeficientes(string Coeffs)
        {
            string pattern = "-?\\d+";

            var Coef = Regex.Matches(Coeffs,pattern);

            double [] Coeff= new double[5];
            int i = 0;

            foreach (var item in Coef)
            {
                Coeff[i++] = Convert.ToDouble(item.ToString());
            }

            return Coeff;
        }
        public double EvalVar(string val)
        {
            return EvalFunction(val, 0);
        }
    }
}
