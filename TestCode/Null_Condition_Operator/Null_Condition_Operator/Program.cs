using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Null_Condition_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;

            a?.Add("a");
            a?.Add("b");

            Console.WriteLine("Count : {0}", a?.Count);
            Console.WriteLine(a?[0]);
            Console.WriteLine(a?[1]);

            a = new ArrayList();

            a?.Add("a");
            a?.Add("b");

            Console.WriteLine(a?.Count);
            Console.WriteLine(a?[0]);
            Console.WriteLine(a?[1]);


            int a2 = 19;


        }
    }
}
