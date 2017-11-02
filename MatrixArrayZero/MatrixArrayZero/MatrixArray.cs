using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixArrayZero
{
    class MatrixArray
    {
        public int[,] MtxArr { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public MatrixArray(int width, int depth)
        {
            MtxArr = new int[width, depth];
            Width = width;
            Depth = depth;
        }

        public void AddToMatrix(int x, int y, int value)
        {
            // If value is 0, set all values in row x and column y to 0, else set value at specified location
            if (value == 0)
            {
                for (int i = 0; i < Width; i++)
                {
                    MtxArr[i, y] = 0;
                }
                for (int j = 0; j < Depth; j++)
                {
                    MtxArr[x, j] = 0;
                }
            }
            else
            {
                MtxArr[x, y] = value;
            }
        }

        // Fills our matrix with random values between 1 and 10
        public void PopulateRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Depth; j++)
                {
                    MtxArr[i, j] = rnd.Next(1, 10);
                }
            }
        }

        // Print our matrix in an easily viewed format
        public void PrintMatrix()
        {
            for (int i = 0; i < Depth; i++)
            {
                string currentLine = "";
                for (int j = 0; j < Width; j++)
                {
                    currentLine += $"{MtxArr[j, i]} ";
                }
                Console.WriteLine(currentLine);
            }
        }
    }
}
