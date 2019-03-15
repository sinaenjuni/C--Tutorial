using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace code005
{

    class Program
    {
        static void ThreadBody()
        {
            Console.WriteLine("In the thread body...");
        }

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(ThreadBody);

            Thread thread = new Thread(threadStart);

            Console.WriteLine("***Start of Main");

            thread.Start();

            Console.WriteLine("*** End of Main");
        }
    }


}
