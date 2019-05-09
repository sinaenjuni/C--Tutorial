using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz05
{
    class Swap<T>
    {
        public T x, y;

        public void swap()
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Swap<int> sw = new Swap<int>();
            sw.x = 1;
            sw.y = 2;
            sw.swap();
            Console.WriteLine("x: " + sw.x + " y: " + sw.y);


            Swap<double> sw1 = new Swap<double>();
            sw1.x = 1.1;
            sw1.y = 4.1;
            sw1.swap();
            Console.WriteLine("x: " + sw1.x + " y: " + sw1.y);

        }
    }
}
