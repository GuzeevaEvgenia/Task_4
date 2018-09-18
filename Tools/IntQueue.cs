using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class IntQueue
    {
        Node head;
        public int Count { get; private set; }
        public void Clear()
        {
            head = new Node();
            Count = 0;
        }
        public void Enqueue(int value)
        {
            head.AddToTail(value);
            Count++;
        }
        public int Dequeue()
        {
            if (Count <= 0)
                throw new InvalidOperationException();
            head = head.Next;
            Count--;
            return head.Value;
        }
        public IntQueue() => Clear();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node Go = head.Next;
            while (Go != null)
            {
                sb.Append(Go.Value);
                if (Go.Next != null)
                    sb.Append(" ");
                Go = Go.Next;
            }
            return sb.ToString();
        }
    }
}
