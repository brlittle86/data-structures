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

        static void BitonicMerge(int[] array, int low, int high, bool dir)
        {
            if (high > 1)
            {
                int mid = high / 2;
                for (int i = low; i < low + mid; ++i)
                {
                    Compare(array, i, i + mid, dir);
                }
                BitonicMerge(array, low, mid, dir);
                BitonicMerge(array, low + mid, mid, dir);
            }
        }

        static void BitonicSort(int[] array, int low, int high, bool dir)
        {
            if (high > 1)
            {
                int mid = high / 2;
                BitonicSort(array, low, mid, ascending);
                BitonicSort(array, low + mid, mid, descending);
                BitonicMerge(array, low, high, dir);
            }
        }
    }
}
