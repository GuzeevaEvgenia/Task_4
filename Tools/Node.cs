using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value = 0, Node next = null)
        {
            Value = value;
            Next = next;
        }
        public void AddToTail(int value)
        {
            if (Next != null)
                Next.AddToTail(value);
            else
                Next = new Node(value);
        }
    }
}
