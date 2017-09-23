using System;

namespace DoublyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList coolList = new DoublyLinkedList(4);

            coolList.AddFirst(8);
            coolList.AddFirst(3);
            coolList.AddFirst(9);
            coolList.AddFirst(56);
            coolList.AddFirst(19);
            coolList.AddLast(14);
            coolList.AddLast(41);
            coolList.AddLast(64);
            coolList.AddLast(15);

            coolList.ViewList();
            Console.WriteLine();

            Console.WriteLine("Let's remove 9:");
            coolList.RemoveByData(9);
            coolList.ViewList();
            Console.WriteLine();

            Console.WriteLine("Now let's remove the first node:");
            coolList.RemoveFirst();
            coolList.ViewList();
            Console.Read();

        }
    }
}
