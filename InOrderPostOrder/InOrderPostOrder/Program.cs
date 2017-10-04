using System;

namespace InOrderPostOrder
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

            //Pre Order Traversal
            Console.WriteLine("Pre-Order Traversal:");
            myTree.PreOrderTraversal();

            //In Order Traversal
            Console.WriteLine("In-Order Traversal:");
            myTree.InOrderTraversal();

            //Post Order Traversal
            Console.WriteLine("Post-Order Traversal:");
            myTree.PostOrderTraversal();
            Console.Read();
        }
    }
}
