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
            stackDemo.Pop();
            stackDemo.Pop();
        }
    }
}
