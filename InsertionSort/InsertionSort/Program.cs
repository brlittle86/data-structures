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
            // For each item in the array, except for the item in index 0, as it is assumed to be in its proper spot at the start
            for (int i = 1; i < sortArray.Length; i++)
            {
                int j = i;
                // While the current value being sorted is not in index 0 of the array
                while (j > 0)
                {
                    // If the value at index j is less than the value at index j - 1, replace the value at j - 1 with j, and decrement j. Else break the while loop.
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
            // Return the sorted array
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
