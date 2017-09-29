using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeQueue
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
}
