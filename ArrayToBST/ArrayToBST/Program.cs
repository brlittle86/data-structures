using System;

namespace ArrayToBST
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 8, 17, 39, 42, 55, 73 };
            BinarySearchTree myTree = new BinarySearchTree(myArray);
            myTree.Root.InOrderTraversal();
            Console.Read();
        }
    }
}
