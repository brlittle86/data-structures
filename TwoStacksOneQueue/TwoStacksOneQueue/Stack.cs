using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacksOneQueue
{
    class Stack : LinkedList
    {
        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
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
    }
}
