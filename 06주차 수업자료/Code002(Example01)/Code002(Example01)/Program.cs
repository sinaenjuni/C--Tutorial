using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code002_Example01_
{
    abstract class Figure
    {
        public int a;
        public abstract void Area();
        public abstract void Girth();
        public abstract void Draw();
    }

    class Squ : Figure
    {
        public int Garo;
        public int Sero;
        public override void Area()
        {
            
            Console.WriteLine($"넓이: {Garo * Sero}");
        }

        public override void Girth()
        {
            Console.WriteLine($"둘레: {(Garo*2) + (Sero*2)}");
        }

        public override void Draw()
        {
            Console.WriteLine($"==사각형=={a}");
        }

    }

    class Cir : Figure
    {
        public Double Bangirm;

        public override void Area()
        {
            Console.WriteLine($"넓이 : {3.14 * Math.Pow(Bangirm, 2)}");
        }

        public override void Girth()
        {
            Console.WriteLine($"둘레 : {2 * 3.14 * Bangirm}");
        }

        public override void Draw()
        {
            Console.WriteLine($"==원=={a}");

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("가로:");
            int garo = int.Parse(Console.ReadLine());
            Console.Write("세로:");
            int sero = int.Parse(Console.ReadLine());
            Console.Write("반지름:");
            Double bangirm = Double.Parse(Console.ReadLine());

            Squ x = new Squ();
            Cir y = new Cir();

            x.Garo = garo;
            x.Sero = sero;
            y.Bangirm = bangirm;

            x.Area();
            x.Girth();
            x.Draw();

            y.Area();
            y.Girth();
            y.Draw();

        }
    }
}
