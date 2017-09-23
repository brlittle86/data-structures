using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    class DoublyLinkedList
    {
        public DNode Head { get; set; }

        public DoublyLinkedList(int data)
        {
            Head = new DNode(data);
        }

        public void AddFirst(int data)
        {
            DNode current = Head;
            Head = new DNode(data);
            Head.Next = current;
            current.Previous = Head;
        }

        public void AddLast(int data)
        {
            DNode runner = Head;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = new DNode(data);
            runner.Next.Previous = runner;
        }
    }
}
