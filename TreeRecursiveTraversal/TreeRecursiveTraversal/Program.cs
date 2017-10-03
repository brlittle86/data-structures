using System;

namespace TreeRecursiveTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree(3)
            {
                Left = new Tree(5)
                {
                    Left = new Tree(8),
                    Right = new Tree(15)
                },
                Right = new Tree(4)
                {
                    Left = new Tree(31),
                    Right = new Tree(1)
                }
            };
            //Root is 3, with children 5 and 4. 5 has children 8 and 15, 4 has children 31 and 1... Order of display should be 3, 5, 8, 15, 4, 31, 1
            myTree.Traversal();
            Console.Read();
        }
    }
}
