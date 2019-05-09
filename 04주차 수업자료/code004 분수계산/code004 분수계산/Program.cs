using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code004_분수계산
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - 1/2 + 1/3 - 1/4 + ... - 1/10 
            // 짝수는 빼기 홀수는 더하기
            double hap = 1;
            int a = 1;
            int d = 1;
            //a/d
            Console.Write("{0} + ", hap);
            while (d < 10)
            {
                d++;
                Console.WriteLine(d);

                if (d % 2 == 0)
                {

                    //d = d * -1; //음수
                    hap -= (double)a / d;
                    Console.Write();
                }
                else
                {
                    hap += (double)a / d;
                   
                }
                
            }
            Console.WriteLine(hap);
        }
    }
}
