using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacksOneQueue
{
    class Queue
    {
        public Stack Stack1 { get; set; }
        public Stack Stack2 { get; set; }

        public Queue(int data)
        {
            Stack1 = new Stack(data);
            Stack2 = new Stack();
        }

        public void Enqueue(int data)
        {
            Stack1.Push(data);
        }

        public Node Dequeue()
        {
            while (Stack1.Head != null)
            {
                Stack2.Push(Stack1.Pop().Data);
            }
            Node temp = Stack2.Pop();
            while (Stack2.Head != null)
            {
                Stack1.Push(Stack2.Pop().Data);
            }
            return temp;
        }
    }
}
