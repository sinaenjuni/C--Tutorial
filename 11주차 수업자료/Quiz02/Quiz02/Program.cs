using System;

namespace Quiz02
{
    delegate int Compare<T>(T a, T b);

    class Program
    {
        static int AsendCompare<T>(T a, T b) where T : IComparable<T>
        {

            return a.CompareTo(b);
        }


        static int DesendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] dataSet, Compare<T> compare)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < dataSet.Length; i++)
            {
                for (j = 0; j < dataSet.Length - (i + 1); j++)
                {
                    if (compare(dataSet[j], dataSet[j + 1]) > 0)
                    {
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
            BubbleSort<int>(dataSet, new Compare<int>(AsendCompare));

            foreach (int i in dataSet)
            {
                Console.WriteLine($"{i} ");
            }


            String[] dataSet1 = { "aa", "bb", "dd", "gg" };

            Console.WriteLine("Sorting descending...");
            BubbleSort<String>(dataSet1, new Compare<String>(DesendCompare));

            foreach (String i in dataSet1)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}
