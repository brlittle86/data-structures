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
            Node temp = Tail;
            Tail.Next = new Node(data);
            Tail = Tail.Next;
            Tail.Previous = temp;
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

        public string IsPalindrome()
        {
            Node start = Head;
            Node end = Tail;

            while (start.Next != null && end.Previous != null)
            {
                if (start.Data.Equals(end.Data) == true)
                {
                    start = start.Next;
                    end = end.Previous;
                }
                else
                {
                    return "Not a palindrome!";
                }
            }
            return "Is a palindrome!";
        }
    }
}
