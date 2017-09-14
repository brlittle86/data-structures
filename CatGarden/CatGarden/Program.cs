using System;

namespace CatGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making a Cat Garden");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("Catnip ");
                    }
                    else
                    {
                        Console.Write("Mint ");
                    }
                }
                    Console.WriteLine();
            }
            Console.Read();
        }
    }
}
