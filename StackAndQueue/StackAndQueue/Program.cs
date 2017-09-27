using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackDemo = new Stack<int>(4);
            stackDemo.Push(6);
            stackDemo.Push(7);
            stackDemo.Push(3);
            stackDemo.Push(1);
            stackDemo.View();
            stackDemo.Pop();
            stackDemo.Pop();
            stackDemo.View();
            stackDemo.Push(18);
            stackDemo.Push(8);
            stackDemo.View();

            Console.WriteLine();
            Queue<string> queueDemo = new Queue<string>("bruh");
            queueDemo.Enqueue("naww");
            queueDemo.View();
            queueDemo.Enqueue("bro");
            queueDemo.View();
            queueDemo.Dequeue();
            queueDemo.View();

            Console.Read();
        }
    }
}
