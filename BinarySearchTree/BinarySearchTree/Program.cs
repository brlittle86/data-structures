using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree(14);
            myTree.BstAdd(9);
            myTree.BstAdd(24);
            myTree.BstAdd(7);
            myTree.BstAdd(12);
            myTree.BstAdd(17);
            myTree.BstAdd(28);

            /* Tree should look like:
             *         14
             *        /  \
             *       9    24
             *      / \   / \
             *     7  12 17 28
             */
            
            //Should display: 14 9 7 12 24 17 28
            Console.WriteLine("Pre-Order Traversal:");
            myTree.PreOrderTraversal();

            //Should display: 9 7 12 14 24 17 28
            Console.WriteLine("In-Order Traversal:");
            myTree.InOrderTraversal();

            //Should display: 9 7 12 24 17 28 14
            Console.WriteLine("Post-Order Traversal:");
            myTree.PostOrderTraversal();

            //Should display: 14 9 24 7 12 17 28
            Console.WriteLine("Breadth-First Traversal:");
            myTree.BreadthTraversal();
            Console.Read();
        }
    }
}
