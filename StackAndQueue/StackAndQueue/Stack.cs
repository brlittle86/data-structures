using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public Stack(T data)
        {
            Head = new Node<T>(data);
            Tail = Head;
        }

        public void Push(T data)
        {
            Node<T> temp = Head;
            Head = new Node<T>(data)
            {
                Next = temp
            };
        }

        public T Pop()
        {
            if (Head == Tail)
            {
                Tail = null;
            }
            Node<T> temp = Head.Next;
            Head.Next = null;
            T value = Head.Data;
            Head = temp;
            return value;
        }
    }
}
