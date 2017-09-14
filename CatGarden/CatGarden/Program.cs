using System;

namespace CatGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making a Cat Garden");

            Array[] catGarden = CatGarden();
            foreach (var item in catGarden)
            {
                foreach (var thing in item)
                {
                    Console.WriteLine(thing);
                }
            }
            Console.Read();
        }

        static Array[] CatGarden()
        {
            Array[] garden = new Array[5];
            for (int i = 0; i < garden.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    string[] rowCatnip = new string[] { "catnip", "catnip", "catnip", "catnip", "catnip" };
                    garden[i] = rowCatnip;
                }
                else
                {
                    string[] rowMint = new string[] { "mint", "mint", "mint", "mint", "mint" };
                    garden[i] = rowMint;
                }
            }

            return garden;
        }
    }
}
