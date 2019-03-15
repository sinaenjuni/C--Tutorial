using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace code006
{
    class Stack<T>
    {
        private T[] stack = new T[100];
        private int sp = -1;
        
        public void Push(T element)
        {
            stack[++sp] = element;

        }

        public T Pop()
        {
            return stack[sp--];
        }

    }

    class Program
    {
      
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<double> stack2 = new Stack<double>();

            stack1.Push(1); stack1.Push(2); stack1.Push(3);

            Console.WriteLine("integer stack = " + stack1.Pop() + stack1.Pop() + stack1.Pop());

            stack2.Push(1.0); stack2.Push(2.0); stack2.Push(3.0);

            Console.WriteLine("double stack = " + stack2.Pop() + stack2.Pop() + stack2.Pop());

        }
    }


}
