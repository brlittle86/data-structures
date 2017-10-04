using System;
using System.Collections.Generic;
using System.Text;

namespace InOrderPostOrder
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

        public void PreOrderTraversal()
        {
            Console.WriteLine(Data);
            if(Left != null) { Left.PreOrderTraversal(); }
            if(Right != null) { Right.PreOrderTraversal(); }
        }

        public void InOrderTraversal()
        {
            if (Left != null) { Left.PreOrderTraversal(); }
            Console.WriteLine(Data);
            if (Right != null) { Right.PreOrderTraversal(); }
        }

        public void PostOrderTraversal()
        {
            if (Left != null) { Left.PreOrderTraversal(); }
            if (Right != null) { Right.PreOrderTraversal(); }
            Console.WriteLine(Data);
        }
    }
}
