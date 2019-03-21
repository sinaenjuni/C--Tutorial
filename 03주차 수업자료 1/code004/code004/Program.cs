using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code004
{
    class Program
    {
        static double PI = 3.141592;

        static void Main(string[] args)
        {
            int r;
            r = int.Parse(Console.ReadLine());

            //Console.WriteLine(4.0 / 3.0);

            double v = (4.0 / 3.0) * PI * Math.Pow(r, 3);

            Console.WriteLine(v);

            double s = 4 * PI * Math.Pow(r, 2);

            Console.WriteLine(s);

        }
    }
}
