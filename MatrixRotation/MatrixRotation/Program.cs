using System;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix myMatrix = new Matrix(5, 5);
            myMatrix.PopulateRandom();
            myMatrix.PrintMatrix();
            Console.WriteLine("Let's rotate Clockwise!");
            myMatrix.RotateClockwise();
            myMatrix.PrintMatrix();
            Console.WriteLine("Let's rotate it Counter-Clockwise a couple times to show it the other direction!");
            myMatrix.RotateCounter();
            myMatrix.RotateCounter();
            myMatrix.PrintMatrix();
            Console.Read();
        }
    }
}
