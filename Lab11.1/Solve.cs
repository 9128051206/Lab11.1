using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    public struct Solve
    {
        public double k;
        public double b;
        public double x;
        public Solve(double k, double b, double x)
        {
            this.k = k;
            this.b = b;
            this.x = x;
        }
        public double root()
        {
            x = -b / k;
            Console.WriteLine("Ответ: {0}", x);
            return x;
        }
    }
}
