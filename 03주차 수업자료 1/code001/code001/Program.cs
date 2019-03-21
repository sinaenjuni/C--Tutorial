using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code001
{
    class Program
    {
       
    
        static double op1(double a, double b, double c)
        {
            double result;

            result = a + b + c / 2;

            return result;
        }

        static double op2(double a, double b, double c, double l)
        {

            double result;

            result = Math.Sqrt(Math.Pow(l - a, 2) + Math.Pow(l - a, 2) + Math.Pow(l - a, 2));

            return result;
        }

        static void Main(string[] args)
        {
            double[] data;
            data = new double[3];

            for (int ia = 0; ia < data.Length; ia++) {
                data[ia] = double.Parse(Console.ReadLine());
            }

            double re1 = op1(data[0], data[1], data[2]);
            Console.WriteLine(re1);
            double re2 = op2(data[0], data[1], data[2], op1(data[0], data[1], data[2]));
            Console.WriteLine(re2);

        }
    }
}
