using System;

namespace TwoStacksOneQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue awesomeQueue = new Queue(1);
            awesomeQueue.Enqueue(2);
            awesomeQueue.Enqueue(3);
            awesomeQueue.Stack1.View();
            Console.WriteLine("Let's add a couple more things to the queue.\n");
            awesomeQueue.Enqueue(4);
            awesomeQueue.Enqueue(5);
            awesomeQueue.Stack1.View();

            Console.WriteLine();

            Console.WriteLine($"{ awesomeQueue.Dequeue().Data} was dequeued!");
            awesomeQueue.Stack1.View();
            Console.Read();
        }
    }
}
