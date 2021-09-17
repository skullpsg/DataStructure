using Datastructure.PriorityQueueNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.StringAlgo.kMostFrequesntWord.Model
{
    public class KMostFrequentPQNode<T> : PriorityQueueNode<T>
    {
        public kMostFrequencyTrieNode TrieNode;
        public KMostFrequentPQNode() : base()
        {

        }

        public KMostFrequentPQNode(T value) : base(value)
        {
            if (value is int)
                this.priority = Convert.ToInt32(value);
            this.value = value;
        }

        public KMostFrequentPQNode(T value, int priority, kMostFrequencyTrieNode node) : base(value, priority)
        {
            this.priority = priority;
            this.value = value;
            this.TrieNode = node;
        }
    }
}
