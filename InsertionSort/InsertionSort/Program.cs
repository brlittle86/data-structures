using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 14, 18, 4, 3, 9, 18, 47, 32, 10 };
            Console.WriteLine($"Our unsorted array: {PrintIntArray(unsortedArray)}.");
            Console.WriteLine($"Now we sort it and it becomes: {PrintIntArray(InsertionSort(unsortedArray))}.");
            Console.Read();
        }

        static int[] InsertionSort(int[] sortArray)
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

        static string PrintIntArray(int[] array)
        {
            string phrase = "";
            foreach (var item in array)
            {
                phrase += " " + item;
            }
            return phrase;
        }
    }
}
