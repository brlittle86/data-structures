using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinkedList = new LinkedList(1);
            myLinkedList.AddNode(2);
            myLinkedList.AddNode(3);
            myLinkedList.AddToFirst(0);
            myLinkedList.ViewLinkedList();
            Console.Read();
        }
    }
}
