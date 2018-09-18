using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalV.Models
{
    public class AlgoritmParams
    {
        public string Expression { get; set; }
        public double IntervalA { get; set; }          
        public double IntervalB { get; set; }

        public AlgoritmParams(string Expression, double IntervalA, double IntervalB)
        {
            this.Expression = Expression;
            this.IntervalA = IntervalA;
            this.IntervalB = IntervalB;
        }

    }
}
