using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;


namespace Example_Queue_p400_
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue qu = new Queue();
            qu.Enqueue(10);
            qu.Enqueue("awdawd");
            qu.Enqueue(3.14);

            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());


        }
    }
}
