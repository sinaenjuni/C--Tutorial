using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace String_Contol_p98__
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = "Good Mornig";

            String numStr = "123456789";

            WriteLine("str : {0}", str);
            WriteLine();

            WriteLine("numStr : {0}", numStr);
            WriteLine();

            ///////////////////////////////////////////////////

            WriteLine("str.IndexOf(\"Good\") : {0}", str.IndexOf("Good"));
            //현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾습니다.

            WriteLine("str.indexOf(\"g\") : {0}", str.IndexOf("g")); 

            WriteLine("str.IndexOf(\"oo\") : {0}" ,str.IndexOf("oo"));

            WriteLine("str.LastIndexOf(\"oo\") : {0}", str.LastIndexOf("oo"));

            WriteLine("numStr.IndexOf(\"7\") : {0}", numStr.LastIndexOf("7"));

            WriteLine("numStr.IndexOf(\"7\") : {0}", numStr.IndexOf("7"));

            //IndexOf, LastIndexOf는 검색을 시작하는 위치만 다르고 결과 인덱스는 왼쪽(0)을 기준으로 출력한다.

            WriteLine(str.StartsWith("G"));

            WriteLine(str.StartsWith("ood"));

            WriteLine(str.EndsWith("Mornig"));

            WriteLine(str.EndsWith("g"));

            //현재 문자열에서 시작, 끝나는 문자나 문자열에 대하여 검색 후 논리형(True, False)으로 출력한다.

            WriteLine(str.Replace("Good", "Nice"));

            //결과를 문자열로 반환

            WriteLine(str.Contains("Good"));



            WriteLine(numStr.ToUpper());

            WriteLine(numStr.Insert(0, "A")); //index 뒤에다가 문자, 문자열 추가

            WriteLine(numStr.Remove(0, 2)); //[0, 1)

            WriteLine(numStr.Substring(0, 2));

            WriteLine(str.Split(' ')[1]);

            String tt = " aaa bbb ccc ";

            WriteLine(tt.Trim());
            WriteLine(tt.TrimStart());
            WriteLine(tt.TrimEnd());


      

        }
    }
}
