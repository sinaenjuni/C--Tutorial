using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code002_화문수
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "1221";
            //string str2 = "123321";


            int strHalfRange = str1.Length / 2;
            Console.WriteLine(strHalfRange);

            Console.WriteLine(String.Compare("1", "1"));


            Console.WriteLine(str1.Substring(0, strHalfRange));
            Console.WriteLine(str1.Substring(2,2));
            //Console.WriteLine(str1.Substring(str1.Length-2, 0));

            Console.WriteLine(String.Compare(str1.Substring(0, strHalfRange), str1.Substring(str1.Length - 2, strHalfRange)));


            //if (String.Compare(str1.Substring(0, strHalfRange), str1.Substring(strHalfRange, str1.Length - 2)){

            


        }
    }
}
