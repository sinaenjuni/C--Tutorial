using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conde005
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, max=0;
            Console.Write("일련의 수: ");


            do
            {
                temp = Console.Read() - '0';
                
                if (temp > max)
                {
                    max = temp;
                    
                }
                Console.Write(temp);
            } while (temp != 0);
            
                Console.WriteLine("최대값 : " + max);
            

        }
    }
}
