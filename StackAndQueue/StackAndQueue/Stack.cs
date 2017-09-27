using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack<T> : LinkedList<T>
    {
        public Stack(T data)
        {
            Head = new Node<T>(data);
            Tail = Head;
        }

        public void Push(T data)
        {
            Node<T> temp = Head;
            Head = new Node<T>(data) { Next = temp };
        }

        public T Pop()
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
