using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(string data)
        {
            Root = new Node(data);
        }

        public void AddLeft(string data)
        {
            Node temp = Root;
            while (temp.Left != null && temp.Right != null)
            {
                temp = temp.Left;
            }
            if (temp.Left == null)
            {
                temp.Left = new Node(data);
            }
            else
            {
                temp.Right = new Node(data);
            }
        }

        public void AddRight(string data)
        {
            Node temp = Root;
            while (temp.Right != null && temp.Left != null)
            {
                temp = temp.Right;
            }
            if (temp.Right == null)
            {
                temp.Right = new Node(data);
            }
            else
            {
                temp.Left = new Node(data);
            }
        }
    }
}
