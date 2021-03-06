﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortedPush
{
    abstract class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void View()
        {
            Node runner = Head;
            string output = "Head -> ";
            while (runner.Next != null)
            {
                output += runner.Data + " <-> ";
                runner = runner.Next;
            }
            output += runner.Data + " -> null";
            Console.WriteLine(output);
        }
    }
}
