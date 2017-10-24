using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayToBST
{
    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void InOrderTraversal()
        {
            if (Left != null) { Left.InOrderTraversal(); }
            Console.WriteLine(Data);
            if (Right != null) { Right.InOrderTraversal(); }
        }

    }

    class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(int[] array)
        {
            Root = ToBST(array, 0, array.Length - 1);
        }

        public Node ToBST(int[] array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (int)Math.Floor((start + end) / 2.0);

            Node newTree = new Node(array[mid])
            {
                Left = ToBST(array, start, mid - 1),
                Right = ToBST(array, mid + 1, end)
            };

            return newTree;
        }
    }
}
