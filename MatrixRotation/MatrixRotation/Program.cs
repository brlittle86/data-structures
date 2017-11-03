using System;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix myMatrix = new Matrix(3, 3);
            myMatrix.PopulateRandom();
            myMatrix.PrintMatrix();
            Console.WriteLine("Let's rotate Clockwise!");
            myMatrix.RotateClockwise();
            myMatrix.PrintMatrix();
            Console.Read();
        }
    }
}
