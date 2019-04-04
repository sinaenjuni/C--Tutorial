using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code003__Example_02_
{
    class Stack
    {
        private int[] st;
        private int sp = -1;
        
        public Stack()
        {
            st = new int[100];
        }
        public Stack(int size)
        {
            st = new int[size];
        }

        public void Push(int data)
        {
            if (sp < st.Length-1 )
            {
                sp++;
                st[sp] = data;
            }
            else
            {
                Console.WriteLine("Error : 인덱스 범위 초과");
            }

        }

        public int Pop()
        {
            if (sp >= 0)
            {
                return st[sp--];
            }else
            {
                return -1;
            }
        }

        public int GetStackPointer()
        {
            return sp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack(100);

            //a.Push(1);
            //a.Push(2);
            //a.Push(3);

            for(int i = 0; i< 100; i++)
            {
                a.Push(i);
            }

            while(a.GetStackPointer() != -1)
            {
                Console.WriteLine(a.Pop());
            }

        }
    }
}
