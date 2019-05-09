using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance001_p2_
{
    abstract class AbstractClass
    {
        protected abstract void AbMathod();

        public void Mathod12()
        {
            Console.WriteLine("추상 클래스 메소드 1");
        }

        public void Mathod2()
        {
            Console.WriteLine("추상 클래스 메소드 2");
        }
    }

    class AbClass : AbstractClass
    {

        protected override void AbMathod()
        {
            throw new NotImplementedException();
        }
    }

    class BaseClass
    {
       public virtual void Mathod1()
        {
            Console.WriteLine("베이스 메소드 1");
        }

        public virtual void Mathod2()
        {
            Console.WriteLine("베이스 메소드 2");

        }

        public void Mathod3()
        {
            Console.WriteLine("베이스 메소드 3");
        }
    }

    class Inheritance : BaseClass
    {
        public new void Mathod1()
        {
            Console.WriteLine("오버라이딩 메소드 1");
        }

        public override void Mathod2()
        {
            Console.WriteLine("오버라이딩 메소드 2");

        }

        public new void Mathod3()
        {
            Console.WriteLine("오버라이딩 메소드 3");
        }

    }


    class CLanguage
    {
        public void Print()
        {
            Console.WriteLine("C Language");
        }

        virtual public void Print2()
        {
            Console.WriteLine("CC");
        }
    }

    class JavaLaanguage : CLanguage
    {
        new public void Pinrt()
        {
            Console.WriteLine("Java Language");
        }

        override public void Print2()
        {
            Console.WriteLine("JJ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Inheritance i = new Inheritance();
            BaseClass b = new BaseClass();
            BaseClass bb = new Inheritance();

       
            i.Mathod1();
            i.Mathod2();
            i.Mathod3();

            b.Mathod1();
            b.Mathod2();
            b.Mathod3();

            bb.Mathod1();
            bb.Mathod2();
            bb.Mathod3();

            JavaLaanguage jj = new JavaLaanguage();

            jj.Print();
            jj.Print2();


            CLanguage c = new CLanguage();
            c.Print();
            c.Print2();

            c = new JavaLaanguage();
            c.Print();
            c.Print2();

         

        }
    }
}
