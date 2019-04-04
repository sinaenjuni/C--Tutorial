using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code001__Page_196__
{
    class Product
    {
        private int price = 100;
        
        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            ref int ref_local_price = ref product.GetPrice();
            int normal_local_price = product.GetPrice();

            product.PrintPrice(); 
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

            ref_local_price = 200;

            product.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

        }
    }
}
