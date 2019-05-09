using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz04
{
    class Program : ApplicationException
    {
        static void Main(string[] args)
        {
            int mysteriousState = 1;

            while (true)
            {
                Console.WriteLine("Who");
                try
                {
                    Console.WriteLine("is");
                    if (mysteriousState == 1) return; //함수 종료
                    Console.WriteLine("that");
                    if (mysteriousState == 2) break; //반복문 종료
                    Console.WriteLine("strange"); 
                    if (mysteriousState == 3) continue; //반복문 회귀
                    Console.WriteLine("but kindly");

                    if (mysteriousState == 4)
                        throw new IndexOutOfRangeException(); //프로그램 종료
                    Console.Write("not at all");
                }
                finally
                {
                    Console.WriteLine("amusing");

                }
                Console.WriteLine("yet compelling");
                break;
            }

            Console.WriteLine("men?");
        }
    }
}
