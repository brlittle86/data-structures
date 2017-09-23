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

        public DNode RemoveFirst()
        {
            DNode current = Head;
            Head = Head.Next;
            Head.Previous = null;
            current.Next = null;
            return current;
        }

        public DNode RemoveByData(int data)
        {
            DNode runner = Head;
            if (runner.Data == data)
            {
                return RemoveFirst();
            }
            else
            {
                while (runner.Next != null && runner.Data != data)
                {
                    runner = runner.Next;
                }
                if (runner.Data != data)
                {
                    Console.WriteLine("Did not find data!");
                    return runner;
                }
                else
                {
                    runner.Previous.Next = runner.Next;
                    runner.Next.Previous = runner.Previous;
                    runner.Next = null;
                    runner.Previous = null;
                    return runner;
                }
            }
        }

        public void ViewList()
        {
            DNode runner = Head;
            string printOut = "";
            while (runner.Next != null)
            {
                printOut += runner.Data + " <-> ";
                runner = runner.Next;
            }
            printOut += runner.Data + " -> null";
            Console.WriteLine(printOut);
        }
    }
}
