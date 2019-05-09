using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivation001
{

    class CLanguage
    { 
        public CLanguage()
        {
            Console.WriteLine("Base Constructor");
        }
        virtual public void Print()
        {
            Console.WriteLine("Base : Virtual Print()");
        }

        virtual public void Print2()
        {
            Console.WriteLine("Base : Virtual Print2()");
        }
    }
    
    class JavaLanguage : CLanguage
    {
        public JavaLanguage()
        {
            Console.WriteLine("Derivation Constructor");
        }

        new public void Print()
        {
            Console.WriteLine("Derivation : new Print()");
        }
        override public void Print2()
        {
            Console.WriteLine("Derivation : override Print2()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            CLanguage cc = new CLanguage();
            cc.Print();
            cc.Print2();
            Console.WriteLine();
            JavaLanguage jj = new JavaLanguage();
            jj.Print();
            jj.Print2();
            Console.WriteLine();
            CLanguage cj = new JavaLanguage();
            cj.Print();
            cj.Print2();

        }
    }
}
