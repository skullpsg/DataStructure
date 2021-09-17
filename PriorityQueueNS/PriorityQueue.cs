using Datastructure.PriorityQueueNS.Model;
using System;

namespace Datastructure.PriorityQueueNS
{
    public class PriorityQueue<T, U> where T : IPriorityQueueNode<U>, new()
    {
        protected PriorityQueueType Type;
        protected T[] Nodes;
        protected int Index = -1;
        protected int Capacity = 0;

        public bool isFull()
        {
            return Index + 1 == Capacity;
        }

        public PriorityQueue(PriorityQueueType type, int capacity)
        {
            this.Nodes = new T[capacity];
            this.Type = type;
            this.Index = -1;
            this.Capacity = capacity;
        }

        public int Enqueue(T node)
        {
            if (node == null)
                throw new NullReferenceException("node Should not be null");

            if (Index == Capacity - 1)
            {
                throw new IndexOutOfRangeException("No more capacity");
            }

            Nodes[++Index] = node;

            BalanceBottomToTop(Index);

            return Index;
        }

        public int UpdatePriority(int index, int newPriority)
        {
            var isMax = Nodes[index].priority < newPriority;
            Nodes[index].priority = newPriority;
            int updateIndex = -1;
            if (Type == PriorityQueueType.MIN)
            {
                if (isMax)
                    updateIndex = BalanceTopToBottom(index);
                else
                    updateIndex = BalanceBottomToTop(index);
            }
            else
            {
                if (isMax)
                    updateIndex = BalanceBottomToTop(index);
                else
                    updateIndex = BalanceTopToBottom(index);
            }
            return index;
        }
        public T Top()
        {
            if (Index == -1)
                return null;
            return Nodes[0];
        }

        public T getNode(int index)
        {
            if (index > Index)
                throw new IndexOutOfRangeException();
            return Nodes[index];
        }

        protected int BalanceBottomToTop(int position)
        {
            int updatedIndex = position;

            if (position >= Capacity || position < 0)
            {
                throw new IndexOutOfRangeException("Index not found");
            }


            int parentPosition = (position - 1) / 2;

            if (!isAligningPriority(parentPosition, position))
            {
                Swap(position, parentPosition);
                updatedIndex = BalanceBottomToTop(parentPosition);
            }
            return updatedIndex;
        }
        protected virtual void Swap(int from, int to)
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
        protected int BalanceTopToBottom(int position)
        {
            int leftPosition = 2 * position + 1;
            int rightPosition = 2 * position + 2;
            int maxIndex = Int32.MaxValue;
            int updateIndex = position;

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
                updateIndex = BalanceTopToBottom(maxIndex);
            }
            return updateIndex;
        }
        public T Dequeue()
        {
            if (Capacity == -1)
                return null;
            var result = Nodes[0];
            Nodes[0] = Nodes[Index];
            Nodes[Index--] = null;
            BalanceTopToBottom(0);
            return result;
        }
        public void Print()
        {
            foreach (var node in Nodes)
            {
                if (node == null)
                    break;
                Console.WriteLine("-------------------");
                Console.WriteLine($"value: {node.value}");
                Console.WriteLine($"count: {node.priority}");
                Console.WriteLine("-------------------");
            }
        }
    }
}
