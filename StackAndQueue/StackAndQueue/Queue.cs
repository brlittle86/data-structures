using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue<T> : LinkedList<T>
    {
        public Queue(T data)
        {
            Head = new Node<T>(data);
            Tail = Head;
        }

        public void Enqueue(T data)
        {
            Tail.Next = new Node<T>(data);
            Tail = Tail.Next;
        }

        public T Dequeue()
        {
            if (Head == Tail) { Tail = null; }
            Node<T> temp = Head.Next;
            Head.Next = null;
            T value = Head.Data;
            Head = temp;
            return value;
        }
    }
}
