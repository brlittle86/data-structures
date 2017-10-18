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

            // Testing a delete with a value not in the tree
            myTree.Delete(myTree, 13);

            // In-Order Traversal, followed by a Delete, then another In-Order Traversal to show working deletion
            // Not currently working 
            myTree.InOrderTraversal();
            myTree.Delete(myTree, 9);
            Console.WriteLine("The value 9 should be replaced by 12, 12 should be gone.");
            myTree.InOrderTraversal();

            Console.Read();
        }
    }
}
