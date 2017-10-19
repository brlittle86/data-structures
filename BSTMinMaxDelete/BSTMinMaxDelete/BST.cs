using System;
using System.Collections.Generic;
using System.Text;

namespace BSTMinMaxDelete
{
    class BST
    {
        public int Data { get; set; }
        public BST Left { get; set; }
        public BST Right { get; set; }

        public BST(int data)
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
                    Left = new BST(data);
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
                    Right = new BST(data);
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
            Queue<BST> queue = new Queue<BST>();
            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                BST temp = queue.Dequeue();
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

        public int FindMin()
        {
            if (Left != null)
            {
                return Left.FindMin();
            }
            else
            {
                return Data;
            }
        }

        public int FindMax()
        {
            if (Right != null)
            {
                return Right.FindMax();
            }
            else
            {
                return Data;
            }
        }

        public void DestroyLeft(BST L, int data)
        {
            if (L.Left.Data == data)
            {
                L.Left = null;
                return;
            }
            else
            {
                DestroyLeft(L.Left, data);
            }
        }

        public void DestroyRight(BST R, int data)
        {
            if (R.Right.Data == data)
            {
                R.Right = null;
                return;
            }
            else
            {
                DestroyRight(R.Right, data);
            }
        }

        public void Delete(BST root, int data)
        {
            if (Data == data)
            {
                if (Left == null && Right == null)
                {
                    root = null;
                }
                else if (Left != null && Right == null)
                {
                    Data = Left.FindMax();
                    DestroyRight(this.Left, Data);
                }
                else
                {
                    Data = Right.FindMin();
                    DestroyLeft(this.Right, Data);
                }
            }
            else if (Data > data)
            {
                if (Left != null)
                {
                    Left.Delete(Left, data);
                    return; 
                }
                else
                {
                    Console.WriteLine("Unable to find that data in this tree. Nothing was deleted.");
                }
            }
            else if (Data < data)
            {
                if (Right != null)
                {
                    Right.Delete(Right, data);
                    return; 
                }
                else
                {
                    Console.WriteLine("Unable to find that data in this tree. Nothing was deleted.");
                }
            }
            else
            {
                Console.WriteLine("Unable to find that data in this tree. Nothing was deleted.");
            }
        }
    }
}
