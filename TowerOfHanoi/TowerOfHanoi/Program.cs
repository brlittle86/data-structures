using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of disks:");
            int disks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"For {disks} disks, make the following moves:");
            Tower(disks, 1, 3);
            int moves = Convert.ToInt32(Math.Pow(2, disks) - 1);
            Console.WriteLine($"This took {moves} moves.");
            Console.Read();
        }

        // Tower of Hanoi - takes in N values and moves them, one at a time, from one pole to a third pole, while ensuring that no value is stacked on top of a lower value.
        public static void Tower(int n, int fromStack, int toStack)
        {
            int helpStack;

            if (n == 1)
            {
                Console.WriteLine($"{fromStack} -> {toStack}");
            }
            else
            {
                helpStack = 6 - (fromStack + toStack);

                // Move all but largest disk to the helpStack
                Tower(n - 1, fromStack, helpStack);

                // Move largest disk to destination stack
                Console.WriteLine($"{fromStack} -> {toStack}");

                // Move disks from helpStack to destination
                Tower(n - 1, helpStack, toStack);
            }
        }
    }
}
