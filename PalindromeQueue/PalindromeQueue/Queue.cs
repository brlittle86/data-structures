using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeQueue
{
    class Queue : LinkedList
    {
        public Queue(string data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        public void Enqueue(string data)
        {
            Tail.Next = new Node(data);
            Tail = Tail.Next;
        }

        public string Dequeue()
        {
            if (Head == Tail) { Tail = null; }
            Node temp = Head.Next;
            Head.Next = null;
            string value = Head.Data;
            Head = temp;
            return value;
        }
    }
}
