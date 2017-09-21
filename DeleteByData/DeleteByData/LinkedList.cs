using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteByData
{
    class LinkedList
    {
        public Node Next { get; set; }

        public LinkedList(int data)
        {
            Next = new Node(data);
        }

        public void AddNode(int data)
        {
            Node runner = Next;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = new Node(data);
        }

        public void ViewLinkedList()
        {
            Node runner = Next;
            string printOut = "";
            while (runner.Next != null)
            {
                printOut += runner.Data + " -> ";
                runner = runner.Next;
            }
            printOut += runner.Data + " -> null";
            Console.WriteLine(printOut);
        }

        public void AddToFirst(int data)
        {
            Node runner = Next;
            Next = new Node(data);
            Next.Next = runner;
        }

        public void FindMiddleNode()
        {
            Node runner = Next;
            Node walker = Next;
            int counter = 1;
            while (runner.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next;
                if (runner.Next != null)
                {
                    runner = runner.Next;
                }
                counter++;
            }
            Console.WriteLine($"The middle of this Linked List is the #{counter} node, and contains the data: {walker.Data}.");
        }

        public void NthNodeFromEnd(int n)
        {
            Node runner = Next;
            Node walker = Next;
            for (int i = 1; i < n; i++)
            {
                if (runner.Next != null)
                {
                    runner = runner.Next;
                }
            }
            while (runner.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next;
            }
            Console.WriteLine(walker.Data);
        }

        public void DataNFromEnd(int data)
        {
            Node runner = Next;
            int counter = 1;
            while (runner.Next != null && runner.Data != data)
            {
                runner = runner.Next;
            }
            if (runner.Data != data)
            {
                Console.WriteLine("Data wasn't found.");
            }
            else
            {
                while (runner.Next != null)
                {
                    runner = runner.Next;
                    counter++;
                }
                Console.WriteLine($"{data} found {counter} nodes from the end.");
            }
        }

        public void DeleteByData(int data)
        {
            Node runner = Next;
            if (runner.Data == data)
            {
                Next = runner.Next;
                runner.Next = null;
            }
            else
            {
                while (runner.Next != null && runner.Next.Data != data)
                {
                    runner = runner.Next;
                }
                if (runner.Next == null)
                {
                    Console.WriteLine("Did not find data.");
                }
                else
                {
                    Node walker = runner.Next;
                    runner.Next = walker.Next;
                    walker.Next = null;
                }
            }
        }
    }
}
