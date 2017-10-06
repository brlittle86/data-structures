using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree(1)
            {
                Left = new Tree(2)
                {
                    Left = new Tree(3),
                    Right = new Tree(4)
                },
                Right = new Tree(5)
                {
                    Left = new Tree(6),
                    Right = new Tree(7)
                }
            };
        }
    }
}
