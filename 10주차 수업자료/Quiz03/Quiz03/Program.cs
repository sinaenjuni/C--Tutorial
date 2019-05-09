using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    class FinallyClause
    {
        public void MethodA()
        {
            try
            {
                Console.WriteLine("1");

                throw new Exception();
            }catch(Exception e)
            {
                Console.WriteLine("2");
            }
        }

        public void MethodB()
        {
            try
            {
                Console.WriteLine("3");
            }
            finally
            {
                Console.WriteLine("4");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            FinallyClause f = new FinallyClause();

            f.MethodA();
            f.MethodB();



        }
    }
}
