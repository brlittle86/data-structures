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
        }
    }
}
