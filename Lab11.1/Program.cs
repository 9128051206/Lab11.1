using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Solve solve = new Solve();
            solve.root();
            Console.ReadKey();
        }
    }
}
