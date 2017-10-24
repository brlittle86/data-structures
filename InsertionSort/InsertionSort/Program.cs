using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] InsertionSort(int[] sortArray)
        {
            for (int i = 1; i < sortArray.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (sortArray[j - 1] > sortArray[j])
                    {
                        int temp = sortArray[j - 1];
                        sortArray[j - 1] = sortArray[j];
                        sortArray[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return sortArray;
        }
    }
}
