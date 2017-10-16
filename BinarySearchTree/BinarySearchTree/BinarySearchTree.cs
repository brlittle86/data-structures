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

        public void PreOrderTraversal()
        {
            Console.WriteLine(Data);
            if (Left != null) { Left.PreOrderTraversal(); }
            if (Right != null) { Right.PreOrderTraversal(); }
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

        public void BreadthTraversal()
        {
            Queue<BinarySearchTree> queue = new Queue<BinarySearchTree>();
            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                BinarySearchTree temp = queue.Dequeue();
                Console.Write(temp.Data + " ");

                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }
        }
    }
}
