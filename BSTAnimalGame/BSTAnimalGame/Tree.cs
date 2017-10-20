using System;
using System.Collections.Generic;
using System.Text;

namespace BSTAnimalGame
{
    class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T data)
        {
            Root = new Node<T>(data);
        }
    }
}
