﻿using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 8, 3, 9, 14, 4, 7, 10, 1, 5, 18, 2 };
            Console.WriteLine($"Our unsorted array is: {PrintIntArray(unsortedArray)}.");
            MergeSort(unsortedArray);
            Console.WriteLine($"Our sorted array is: {PrintIntArray(unsortedArray)}.");
            Console.Read();
        }

        private static void Merge(int[] array, int low, int mid, int high)
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

        public static void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = (low / 2) + (high / 2);
                MergeSort(array, low, mid);
                MergeSort(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
        }

        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
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
