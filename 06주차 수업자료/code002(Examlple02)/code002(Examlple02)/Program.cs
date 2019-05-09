using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code002_Examlple02_
{

    public interface IFigure
    {
        void Area();
        void Grith();
        void Draw();
    }

    class Rectangle : IFigure
    {
        int a = 0, b = 0;

        public Rectangle(int a , int b)
        {
            this.a = a;
            this.b = b;

        }


        public void Area()
        {
            Console.WriteLine(a*b);
        }

        public void Draw()
        {
           
        }

        public void Grith()
        {
            Console.WriteLine((a * 2) + (b * 2));
        }
    }

    class Cir : IFigure
    {
        double r;

        public Cir(double r)
        {
            this.r = r;
        }
        public void Area()
        {
            Console.WriteLine(3.14 * Math.Pow(r, 2));
        }

        public void Draw()
        { 

        }

        public void Grith()
        {
            Console.WriteLine(2 * 3.14 * r);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(20, 10);

            r.Area();
            r.Grith();
            r.Draw();

            Cir c = new Cir(5);

            c.Area();
            c.Grith();
            c.Draw();


        }
    }
}
