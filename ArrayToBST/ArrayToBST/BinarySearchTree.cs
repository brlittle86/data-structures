using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayToBST
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

        public void BstAdd(int data)
        {
            if (data < Data)
            {
                if (Left == null)
                {
                    Left = new BinarySearchTree(data);
                    return;
                }
                else
                {
                    Left.BstAdd(data);
                    return;
                }
            }
            else if (data > Data)
            {
                if (Right == null)
                {
                    Right = new BinarySearchTree(data);
                    return;
                }
                else
                {
                    Right.BstAdd(data);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Identical data found, no new leaf added.");
            }
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

        public BinarySearchTree ArrayToBST(int[] array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (int)((start + end) / 2);

            BinarySearchTree newTree = new BinarySearchTree(array[mid])
            {
                Left = ArrayToBST(array, start, mid - 1),
                Right = ArrayToBST(array, start + 1, mid)
            };

            return newTree;
        }
    }
}
