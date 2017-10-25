using System;

namespace BitonicSortAlgorithm
{
    class Program
    {
        const bool ascending = true;
        const bool descending = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        static void Compare(int[] array, int i, int j, bool dir)
        {
            if (dir == (array[i] > array[j]))
            {
                Swap(array, i, j);
            }
        }
    }
}
