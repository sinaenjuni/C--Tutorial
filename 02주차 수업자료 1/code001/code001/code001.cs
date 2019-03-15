using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code001
{

    class CoffeeMaker
    {
        public bool onState;
        public void startCoffeeMaker()
        {
            if(onState == true)
            {
                Console.WriteLine("The CoffeeMaker is already on");

            }
            else
            {
                onState = true;
                Console.WriteLine("The CoffeeMaker is now on");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker();
            coffeeMaker.onState = true;
            coffeeMaker.startCoffeeMaker(
        }
    }


}
