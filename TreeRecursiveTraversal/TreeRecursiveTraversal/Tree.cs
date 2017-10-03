using System;
using System.Collections.Generic;
using System.Text;

namespace TreeRecursiveTraversal
{
    class Tree
    {
        public int Data { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public Tree(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void Traversal()
        {
            if (Left != null)
            {
                Left.Traversal();
            }
            if (Right != null)
            {
                Right.Traversal();
            }
            Console.WriteLine(Data);
        }
    }
}
