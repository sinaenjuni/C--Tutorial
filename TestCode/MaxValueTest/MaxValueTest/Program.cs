using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueTest
{
    class Program
    {
        static void Main(string[] args)
        {

            uint a;

            a = uint.MinValue;

            Console.WriteLine("Min : {0}",a);

            a = a - 1;

            Console.WriteLine($"Min - 1 : {a}");


            a = uint.MaxValue;

            Console.WriteLine($"Max : {a}");

            a = a + 1;

            Console.WriteLine($"Max + 1 : {a}");





            int b;
            b = int.MinValue;

            Console.WriteLine("Min : {0}", b);

            b = int.MaxValue;

            Console.WriteLine($"Max : {b}");

            b = b + 1;

            Console.WriteLine($"Max + 1 : {b}");



        }
    }
}
