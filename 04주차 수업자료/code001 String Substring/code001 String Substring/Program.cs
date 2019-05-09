using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code001_String_Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Good Morning";

            Console.WriteLine(str.Substring(0, 5));
            //0번째 인덱스를 포함하고 4번째 인덱스는 포함하지 않는 범위 [0, 4)
            Console.WriteLine(str.Substring(5));
            //0부터 4번째 인덱스를 제외한 나머지 문자 출력

            Console.WriteLine();

            string[] arr = str.Split(new String[] {" "}, StringSplitOptions.None);
            Console.WriteLine("Word Count : {0}", arr.Length);

            foreach(string s in arr)
            {
                Console.WriteLine("{0}", s);
            }



        }
    }
}
