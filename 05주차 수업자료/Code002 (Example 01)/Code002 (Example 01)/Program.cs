using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code002__Example_01_
{
    class Fracktion
    {
        public int numerrator;
        public int denominator;

        public void setNumerator(int numerrator)
        {
            this.numerrator = numerrator;
        }

        public void setDenoinator(int denominator)
        {
            this.denominator = denominator;
        }

        public Fracktion(int numerrator, int denominator)
        {
            this.numerrator = numerrator;
            this.denominator = denominator;
        }

        public static Fracktion AddFraction(Fracktion x1, Fracktion x2)
        {

            int numer = (x1.numerrator * x2.denominator) + (x1.denominator * x2.numerrator);
            int deno = (x1.denominator * x2.denominator);
            Fracktion result = new Fracktion(numer, deno);
           
            return gi(result);
        }

        public static Fracktion SubFraction(Fracktion x1, Fracktion x2)
        {

            int numer = (x1.numerrator * x2.denominator) - (x1.denominator * x2.numerrator);
            int deno = (x1.denominator * x2.denominator);
            Fracktion result = new Fracktion(numer, deno);

            return gi(result);

        }

        public static Fracktion MulFraction(Fracktion x1, Fracktion x2)
        {

            int numer = x1.numerrator * x2.numerrator;
            int deno = x1.denominator * x2.denominator;
            Fracktion result = new Fracktion(numer, deno);
            return gi(result);
        }

        public static Fracktion DivFraction(Fracktion x1, Fracktion x2)
        {

            int numer = x1.numerrator * x2.denominator;
            int deno = x1.denominator * x2.numerrator;
            Fracktion result = new Fracktion(numer, deno);
            return gi(result);
        }

        private static int gcd(Fracktion result)
        {
            Fracktion res = result;
            int a = res.numerrator;
            int b = res.denominator;
            
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
            
        }

        private static Fracktion gi(Fracktion result) 
        {
            Fracktion resultGi = result;

            int t = gcd(result);

            resultGi.setNumerator(result.numerrator / t);
            resultGi.setDenoinator(result.denominator / t);

            return resultGi;
        }

        public override string ToString()
        {
            return numerrator.ToString() + "/" + denominator.ToString();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Fracktion c1, c2;
            c1 = new Fracktion(1, 2);
            c2 = new Fracktion(3, 4);

            Console.WriteLine("{0} + {1} = {2}", c1, c2, Fracktion.AddFraction(c1, c2));
            Console.WriteLine("{0} - {1} = {2}", c1, c2, Fracktion.SubFraction(c1, c2));
            Console.WriteLine("{0} * {1} = {2}", c1, c2, Fracktion.MulFraction(c1, c2));
            Console.WriteLine("{0} / {1} = {2}", c1, c2, Fracktion.DivFraction(c1, c2));
        }
    }
}
