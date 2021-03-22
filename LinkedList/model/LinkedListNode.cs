    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.LinkedList.model
{
    public class LinkedListNode
    {
        public int Value;
        public LinkedListNode Next;
        public LinkedListNode(int Value, LinkedListNode Next)
        {
            this.Value = Value;
            this.Next = Next;
        }

        public static LinkedListNode create(int value)
        {
            return new LinkedListNode(value, null);
        }

    }
}
