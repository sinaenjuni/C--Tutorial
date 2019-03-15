using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code002
{
    class Even
    {
        int evenNumber;

        public Even(int i)
        {
            evenNumber = (i % 2 == 0) ? i : i + 1;
        }

        public static Even operator ++(Even e)
        {
            e.evenNumber += 2;
            return e;
        }

        public static Even operator --(Even e)
        {
            e.evenNumber -= 2;
            return e;
        }

        public void printEven()
        {
            Console.WriteLine("EvenNumber = " + evenNumber);
        }

    }
   

    class Program
    {
        static void Main(string[] args)
        {

            Even even = new Even(2);
            even.printEven();
            even++;
            even.printEven();
            even--;
            even.printEven();

            ++even;
            even.printEven();
            --even;
            even.printEven();
        }
    }


}
