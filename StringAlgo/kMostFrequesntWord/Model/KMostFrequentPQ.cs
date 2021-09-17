using Datastructure.PriorityQueueNS;
using Datastructure.PriorityQueueNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.StringAlgo.kMostFrequesntWord.Model
{
    public class KMostFrequentPQ<T, U> : PriorityQueue<T, U> where T : KMostFrequentPQNode<U>, new()
    {
        public KMostFrequentPQ(PriorityQueueType type, int capacity) : base(type, capacity)
        {

        }

        public int UpdatePriority(int index, int newPriority, kMostFrequencyTrieNode node)
        {
            var isMax = Nodes[index].priority < newPriority;
            Nodes[index].priority = newPriority;
            int updateIndex = -1;
            if (Type == PriorityQueueType.MIN)
            {
                if (isMax)
                {
                    updateIndex = BalanceTopToBottom(index);
                }
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
            return updateIndex;
        }

        protected override void Swap(int from, int to)
        {
            Nodes[from].TrieNode.PQIndex = to;
            Nodes[to].TrieNode.PQIndex = from;

            var temp = Nodes[from];
            Nodes[from] = Nodes[to];
            Nodes[to] = temp;
        }

        public int Enqueue(T node, kMostFrequencyTrieNode trie)
        {
            int index = Enqueue(node);
            Nodes[index].TrieNode = trie;
            return index;
        }

        public T Dequeue(T node, kMostFrequencyTrieNode trie)
        {
            T index = Dequeue();
            index.TrieNode.PQIndex = -1;
            return index;
        }

    }
}
