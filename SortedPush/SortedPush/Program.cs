using System;

namespace SortedPush
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(4);
            myStack.SortedPush(3);
            myStack.SortedPush(8);
            myStack.SortedPush(21);
            myStack.SortedPush(12);
            myStack.SortedPush(5);
            myStack.View();
            Console.Read();
        }
    }
}
