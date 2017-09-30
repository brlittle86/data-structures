using System;
using System.Collections.Generic;
using System.Text;

namespace SortedPush
{
    class Stack : LinkedList
    {
        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        public Stack()
        {
            Head = null;
            Tail = null;
        }

        public void Push(int data)
        {
            Node temp = Head;
            Head = new Node(data) { Next = temp };
        }

        public Node Pop()
        {
            if (Head == Tail) { Tail = null; }
            Node temp = Head.Next;
            Head.Next = null;
            Node value = Head;
            Head = temp;
            return value;
        }

        public void SortedPush(int data)
        {
            List<int> tempList = new List<int>
            {
                data
            };
            while (Head != null)
            {
                tempList.Add(Pop().Data);
            }
            tempList.Sort();
            foreach (int d in tempList)
            {
                Push(d);
            }
        }
    }
}
