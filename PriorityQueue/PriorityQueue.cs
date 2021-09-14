using Datastructure.PriorityQueue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.PriorityQueue
{
    public class PriorityQueue
    {
        private PriorityQueueType Type;
        private IPriorityQueueNode<int>[] Nodes;
        private int Index = -1;
        private int Capacity = 0;

        public PriorityQueue(PriorityQueueType type, int capacity)
        {
            this.Nodes = new PriorityQueueNode[capacity];
            this.Type = type;
            this.Index = -1;
            this.Capacity = capacity;
        }

        public void Enqueue(PriorityQueueNode node)
        {
            if (node == null)
                throw new NullReferenceException("node Should not be null");

            if (Index == Capacity - 1)
            {
                throw new IndexOutOfRangeException("No more capacity");
            }

            Nodes[++Index] = node;

            BalanceBottomToTop(Index);
        }
        private void BalanceBottomToTop(int position)
        {
            if (position >= Capacity || position < 0)
            {
                throw new IndexOutOfRangeException("Index not found");
            }


            int parentPosition = (position - 1) / 2;

            if (!isAligningPriority(parentPosition, position))
            {
                Swap(position, parentPosition);
                BalanceBottomToTop(parentPosition);
            }

        }
        private void Swap(int from, int to)
        {
            var temp = Nodes[from];
            Nodes[from] = Nodes[to];
            Nodes[to] = temp;
        }
        public Boolean isAligningPriority(int a, int b)
        {
            // Max priority as default
            bool result = Nodes[a].priority > Nodes[b].priority ? true : false;
            if (Type == PriorityQueueType.MIN)
            {
                result = !result;
            }

            return result;
        }
        private void BalanceTopToBottom(int position)
        {
            int leftPosition = 2 * position + 1;
            int rightPosition = 2 * position + 2;
            int maxIndex = Int32.MaxValue;

            if (leftPosition < Capacity && leftPosition <= Index && !isAligningPriority(position, leftPosition))
            {
                maxIndex = leftPosition;
            }


            if (rightPosition < Capacity && rightPosition <= Index && !isAligningPriority(position, rightPosition))
            {
                maxIndex = rightPosition;
            }

            if (maxIndex != Int32.MaxValue)
            {
                Swap(maxIndex, position);
                BalanceTopToBottom(maxIndex);
            }
        }
        public IPriorityQueueNode<int> Dequeue()
        {
            if (Capacity == -1)
                return null;
            var result = Nodes[0];
            Nodes[0] = Nodes[Index];
            Nodes[Index--] = null;
            BalanceTopToBottom(0);
            return result;
        }
    }
}
