
using System;
using System.ComponentModel;

namespace Datastructure.PriorityQueueNS.Model
{
    public class PriorityQueueNode<T> : IPriorityQueueNode<T>
    {
        public PriorityQueueNode()
        {

        }
        public PriorityQueueNode(T value)
        {
            if (value is int)
                this.priority = Convert.ToInt32(value); ;
            this.value = value;
        }

        public PriorityQueueNode(T value, int priority)
        {
            this.priority = priority;
            this.value = value;
        }
    }
}
