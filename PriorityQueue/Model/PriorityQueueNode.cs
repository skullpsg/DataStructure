using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.PriorityQueue.Model
{
    public class PriorityQueueNode : IPriorityQueueNode<int>
    {
        public PriorityQueueNode(int value)
        {
            this.priority = value;
            this.value = value;
        }
        public PriorityQueueNode(int value, int priority)
        {
            this.priority = value;
            this.value = value;
        }
    }
}
