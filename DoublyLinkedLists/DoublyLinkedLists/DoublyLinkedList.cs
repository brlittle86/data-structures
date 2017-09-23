using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    class DoublyLinkedList
    {
        public DNode Head { get; set; }

        public DoublyLinkedList(int data)
        {
            Head = new DNode(data);
        }
    }
}
