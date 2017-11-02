using System;

namespace MatrixArrayZero
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixArray myMatrix = new MatrixArray(10, 7);
            myMatrix.PopulateRandom();
            myMatrix.PrintMatrix();
            Console.WriteLine("Now, let us add a 0 at position [3, 4].");
            myMatrix.AddToMatrix(3, 4, 0);
            myMatrix.PrintMatrix();
            Console.Read();
        }
    }
}
