using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Merge(int[] array, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while ((left <= mid) && (right <= high))
            {
                if (array[left] < array[right])
                {
                    temp[tempIndex] = array[left];
                    left += 1;
                }
                else
                {
                    temp[tempIndex] = array[right];
                    right += 1;
                }
                tempIndex += 1;
            }

            while (left <= mid)
            {
                temp[tempIndex] = array[left];
                left += 1;
                tempIndex += 1;
            }

            while (right <= high)
            {
                temp[tempIndex] = array[right];
                right += 1;
                tempIndex += 1;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                array[low + i] = temp[i];
            }
        }
    }
}
