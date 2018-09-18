using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace RootsClassLibrary
{
    public class Evaluador
    {
        public int Presition { get; set; }

        public Evaluador()
        {

        }

        public double EvalFunction(string Expresion, double Val)
        {
            string ex = "f(" + Val + ")";
            Function f = new Function("f(x) = "+ Expresion);
            Expression e1 = new Expression(ex,f);

            return e1.calculate();

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
