using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node
    {
        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string data)
        {
            Value = data;
            Left = null;
            Right = null;
        }
    }
}
