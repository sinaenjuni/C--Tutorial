using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArratExample_p369_
{
    class Program
    {
        static int[,] ArrayMul(int[,] a, int[,] b)
        {
            int[,] result1 = new[,] { { 0, 0 }, { 0, 0 } };

            result1[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result1[0, 0] = a[0, 0] * b[0, 0] + a[1, 1] * b[1, 1];
            result1[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result1[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result1[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];

            for(int i = 0; i < result1.Length; i++)
            {
                for (int j = 0; j < result1.Length; j++)
                {
                    result1[i, i] = a[i,j] * b[] + a[] * b[];

                }

            }

            return result1;
        }

        static void Main(string[] args)
        {
            int[,] a = { { 3, 2 }, { 1, 4 } };
            int[,] b = { { 9, 2 }, { 1, 7 } };


            Console.WriteLine(a[0, 0]);

        }
    }
}
