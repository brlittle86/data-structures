using System;

namespace PalindromeQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queueDemo = new Queue("t");
            queueDemo.Enqueue("a");
            queueDemo.Enqueue("c");
            queueDemo.Enqueue("o");
            queueDemo.Enqueue("c");
            queueDemo.Enqueue("a");
            queueDemo.Enqueue("t");
            queueDemo.View();
            Console.WriteLine(queueDemo.IsPalindrome());

            Queue otherQueue = new Queue("b");
            otherQueue.Enqueue("a");
            otherQueue.Enqueue("n");
            otherQueue.Enqueue("a");
            otherQueue.Enqueue("n");
            otherQueue.Enqueue("a");
            otherQueue.Enqueue("s");
            otherQueue.View();
            Console.WriteLine(otherQueue.IsPalindrome());

            Console.Read();
        }
    }
}
