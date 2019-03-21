using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conde003
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float weight;

            height = float.Parse(Console.ReadLine());
            weight = float.Parse(Console.ReadLine());

            float SW = (float)((height - 100) * 0.9);
            Console.WriteLine("표준 체중: " + SW);

            double B = weight / SW * 100;
            Console.WriteLine("비만도: " + B);


        }
    }
}
