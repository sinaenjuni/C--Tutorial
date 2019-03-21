using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = double.PositiveInfinity + double.PositiveInfinity;
            Console.WriteLine(a);

            a = double.NegativeInfinity + double.NegativeInfinity;
            Console.WriteLine(a);

            a = double.PositiveInfinity / double.PositiveInfinity;
            Console.WriteLine(a);

            a = double.MaxValue / double.PositiveInfinity;
            Console.WriteLine(a);





        }
    }
}
