using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalV.Models
{
    class Biseccion
    {
        public string Iteration { get; set; }
        public string Value_a { get; set; }
        public string Value_b { get; set; }
        public string Value_pm { get; set; }
        public string Value_fa { get; set; }
        public string Value_fb { get; set; }
        public string Value_fpm { get; set; }
        public string Value_fabs { get; set; }

        public Biseccion(string Iteration, string Value_a, string Value_b, string Value_pm,
            string Value_fa, string Value_fb, string Value_fpm, string Value_fabs)
        {
            this.Iteration = Iteration;
            this.Value_a = Value_a;
            this.Value_b = Value_b;
            this.Value_pm = Value_pm;
            this.Value_fa =Value_fa;
            this.Value_fb = Value_fb;
            this.Value_pm = Value_pm;
            this.Value_fabs = Value_fabs;
        }
    }
}
