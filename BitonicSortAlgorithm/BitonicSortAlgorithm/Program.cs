using System;
using System.Threading.Tasks;

namespace BitonicSortAlgorithm
{
    class Program
    {
        const bool ascending = true;
        const bool descending = false;

        static void Main(string[] args)
        {
            const int size = 200000;
            Random random = new Random();
            int[] randomValues = new int[size];
            for (int i = 0; i < size; ++i)
            {
                randomValues[i] = random.Next(1, 5000);
            }
            Console.WriteLine("Press any key to begin our Bitonic Sort...");
            Console.ReadKey();
            ParallelBitonicSort(randomValues);
            Console.WriteLine("Sorting complete!");
            Console.Read();
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

        static void BitonicSort(int[] array)
        {
            BitonicSort(array, 0, array.Length, ascending);
        }

        static void ParallelBitonicMerge(int[] array, int low, int high, bool dir)
        {
            if (high > 500)
            {
                int mid = high / 2;
                for (int i = low; i < low + mid; ++i)
                {
                    Compare(array, i, i + mid, dir);
                }

                Parallel.Invoke(
                    () => ParallelBitonicMerge(array, low, mid, dir),
                    () => ParallelBitonicMerge(array, low + mid, mid, dir)
                );
            }
            else if (high > 1)
            {
                BitonicMerge(array, low, high, dir);
            }
        }

        static void ParallelBitonicSort(int[] array, int low, int high, bool dir)
        {
            if (high > 1)
            {
                int mid = high / 2;
                Parallel.Invoke(
                    () => ParallelBitonicSort(array, low, mid, ascending),
                    () => ParallelBitonicSort(array, low + mid, mid, descending)
                );

                ParallelBitonicMerge(array, low, high, dir);
            }
        }

        static void ParallelBitonicSort(int[] array)
        {
            ParallelBitonicSort(array, 0, array.Length, ascending);
        }
    }
}
