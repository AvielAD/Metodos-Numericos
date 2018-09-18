using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalV.Models
{
    public class Biseccion
    {
        public string Iteration { get; set; }
        public string Value_a { get; set; }
        public string Value_b { get; set; }
        public string Value_pm { get; set; }
        public string Value_fa { get; set; }
        public string Value_fb { get; set; }
        public string Value_fpm { get; set; }
        public string Value_fabs { get; set; }

        public Biseccion(string It, string a, string b, string pm, string fa, string fb, string fpm, string fabs)
        {
            Iteration = It;
            Value_a = a;
            Value_b = b;
            Value_pm = pm;
            Value_fa = fa;
            Value_fb = fb;
            Value_fpm = fpm;
            Value_fabs = fabs;
        }
    }
}
