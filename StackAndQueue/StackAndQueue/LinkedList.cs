using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    abstract class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public void View()
        {
            Node<T> runner = Head;
            string output = "";
            while (runner.Next != null)
            {
                output += runner.Data + " -> ";
                runner = runner.Next;
            }
            output += runner.Data + " -> null";
            Console.WriteLine(output);
        }
    }
}
