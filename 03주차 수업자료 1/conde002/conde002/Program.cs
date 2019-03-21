using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conde002
{

    class Program
    {

        static double op1(double a, int n)
        {
            double result;


            result = Math.Log(Math.Pow(a, n));


            return result;
        }

        static void Main(string[] args)
        {
            double[] data = new double[3];

            for(int i = 0; i<data.Length; i++)
            {
                data[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }


            double re1 = op1(data[0] - data[1], (int)data[3]);
            Console.WriteLine(re1);

            Console.WriteLine(Math.Abs(Math.Pow(data[0], 2) - Math.Pow(data[1], 2)));

        }
    }
}
