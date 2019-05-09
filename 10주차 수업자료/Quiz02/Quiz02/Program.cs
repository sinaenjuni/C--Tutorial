using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{

    class Ex : Exception
    {

    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 Entering First try block"); //1
            try
            {
                Console.WriteLine("2 Entering second fry block"); //2
                try
                {
                    throw new Ex(); 
                }
                finally
                {
                    Console.WriteLine("3 Finally in 2nd try block"); //3
                }
            }catch(Ex e)
            {
                Console.WriteLine("4 Caught Ex in first try block");//4
            }
            finally
            {
                Console.WriteLine("5 Finally in 1st try block");//5
            }

        }
    }
}
