using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_week03_1_
{
    class Program
    {

        static readonly double PI = 3.14; 
        //실행 시간에 할당되기 때문에 static으로 선언 해야함.
        const int a = 1; 
        //반면 const는 컴파일 시간에 할당되기 때문에 static으로 선언하지 않아도 static 메소드나 클래스에서 사용이 가능

        static int @int = 23;
        static double @double = 3.14;
        //'@'기호는 지정어를 명칭으로 사용할 수 있도록 만들어 준다.
        //int @a = 10; Error: @기호는 지정어에만 사용이 가능(지정어를 명칭으로 사용)

        int aa = 19;

        static void Main(string[] args)
        {

            Console.WriteLine(PI);
            Console.WriteLine(@int);
            Console.WriteLine(@double);

            @int++;
            @double++;

            Console.WriteLine(PI);
            Console.WriteLine(@int);
            Console.WriteLine(@double);


            String str  = "Hello \t World";
            String str1 = "Hello \\t World";
            String str2 = @"Hello \t World";

            Console.WriteLine($"{str}\n" +
                $"{str1}\n" +
                $"{str2}");
           
        }
    }
}
/*
3.14
23
3.14
3.14
24
4.14
Hello    World
Hello \t World
Hello \t World
*/