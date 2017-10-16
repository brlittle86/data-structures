using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public int Data { get; set; }
        public BinarySearchTree Left { get; set; }
        public BinarySearchTree Right { get; set; }

        public BinarySearchTree(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
