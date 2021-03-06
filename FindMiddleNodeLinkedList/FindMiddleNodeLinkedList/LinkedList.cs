﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMiddleNodeLinkedList
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
    }
}
