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
    }
}
