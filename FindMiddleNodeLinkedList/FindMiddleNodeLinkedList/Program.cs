using System;

namespace FindMiddleNodeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinkedList = new LinkedList(11);
            myLinkedList.AddNode(52);
            myLinkedList.AddNode(23);
            myLinkedList.AddNode(43);
            myLinkedList.AddNode(65);
            myLinkedList.AddNode(16);
            myLinkedList.AddNode(87);
            myLinkedList.AddNode(82);
            myLinkedList.AddNode(91);
            myLinkedList.AddNode(14);
            myLinkedList.AddNode(111);
            myLinkedList.AddNode(162);
            myLinkedList.AddToFirst(0);
            myLinkedList.ViewLinkedList();
            myLinkedList.FindMiddleNode();
            Console.Read();
        }
    }
}
