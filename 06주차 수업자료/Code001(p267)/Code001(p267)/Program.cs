using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code001_p267_
{
    class Cat
    {
        public String name;
        public String color;

        public Cat()
        {
            name = "";
            color = "";
             
        }

        public Cat(String name, String color)
        {
            this.name = name;
            this.color = color;
        }

        ~Cat()
        {
            Console.WriteLine($"{name} : 잘가");
        }

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "햐얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.name} : {kitty.color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.name} : {nero.color}");




        }
    }
}
