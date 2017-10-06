using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
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

        public void BreadthTraversal()
        {
            Queue<Tree> queue = new Queue<Tree>();
            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                Tree temp = queue.Dequeue();
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
