using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    delegate int Compare(int a, int b);

    class Program
    {
        static int AsendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }


        static int DesendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;

        }

        static void BubbleSort(int[] dataSet, Compare compare)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for(i = 0; i < dataSet.Length; i++)
            {
                for(j = 0; j < dataSet.Length-(i+1); j++)
                {
                    if (compare(dataSet[j], dataSet[j + 1]) > 0) {
                        temp = dataSet[j + 1];
                        dataSet[j + 1] = dataSet[j];
                        dataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            int[] dataSet = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(dataSet, new Compare(AsendCompare));

            foreach(int i in dataSet)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine("Sorting descending...");
            BubbleSort(dataSet, new Compare(DesendCompare));

            foreach (int i in dataSet)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}
