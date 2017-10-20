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
        public Node ToBST(int[] array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (int)((start + end) / 2);

            Node newTree = new Node(array[mid])
            {
                Left = ToBST(array, start, mid - 1),
                Right = ToBST(array, start + 1, mid)
            };

            return newTree;
        }
    }
    class BinarySearchTree
    {
        public Node Root { get; set; }

    }
}
