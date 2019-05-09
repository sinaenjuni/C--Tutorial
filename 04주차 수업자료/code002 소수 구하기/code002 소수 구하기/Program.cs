using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code002_소수_구하기
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;
            int m = 0;
            int i = 0;
            int[] arr = new int[99];

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = k++;
            }

            i = 0;
            k = 0;

            //i++;
            m = arr[i]; //2저장

            //2의 배수는 모두 소수가 아니다.
            //2

            Console.WriteLine(arr.Length);
                while (k < arr.Length) {
                Console.WriteLine(k);
                k += m;
                    if (arr[k] != 0)
                    { 
                        //Console.WriteLine("{0} ", k);/
                        arr[k] = 0;
                    }
                }
                
            




            foreach (int s in arr)
            {
                Console.Write("{0} ", s);
            }


        }
    }
}
