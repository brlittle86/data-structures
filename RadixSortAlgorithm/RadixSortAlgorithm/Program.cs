using System;

namespace RadixSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void RadixSort(int[] array)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }

            int p = 1;
            int pass = 1;

            while (max / p > 0)
            {
                array = CountSort(array, array.Length, p);
                Console.WriteLine(String.Join(" ", array));
                pass++;
                p *= 10;
            }
        }

        public static int[] CountSort(int[] array, int max, int p)
        {
            int[] output = new int[max];
            int[] count = new int[10];

            for (int i = 0; i < max; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = max - 1; i >= 0; i--)
            {
                output[count[(array[i] / p) % 10] - 1] = array[i];
                count[(array[i] / p) % 10]--;
            }

            return output;
        }
    }
}
