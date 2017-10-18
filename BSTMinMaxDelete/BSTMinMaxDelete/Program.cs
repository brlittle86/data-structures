using System;

namespace BSTMinMaxDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            BST myTree = new BST(14);
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

            // This should return 7
            Console.WriteLine($"The minimum value is {myTree.FindMin()}.");
            // This should return 28
            Console.WriteLine($"The maximum value is {myTree.FindMax()}.");

            Console.Read();
        }
    }
}
