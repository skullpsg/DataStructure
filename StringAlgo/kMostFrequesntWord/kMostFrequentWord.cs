using Datastructure.PriorityQueueNS;
using Datastructure.PriorityQueueNS.Model;
using Datastructure.StringAlgo.kMostFrequesntWord.Model;
using Datastructure.TrieNS;
using Datastructure.TrieNS.Model;
using System;

namespace Datastructure.StringAlgo.WordCountInPara
{
    public class kMostFrequentWord
    {
        private KMostFrequentPQ<KMostFrequentPQNode<String>, String> priorityQueue;
        private KMostTrie<kMostFrequencyTrieNode> trie;

        public kMostFrequentWord(int capacity)
        {
            priorityQueue = new KMostFrequentPQ<KMostFrequentPQNode<String>, String>(PriorityQueueType.MIN, capacity);
            trie = new KMostTrie<kMostFrequencyTrieNode>(new kMostFrequencyTrieNode('*'));
        }

        public void Load(string para)
        {
            var splitedStrs = para.Split(' ');
            foreach (var str in splitedStrs)
            {
                this.Add(str);
            }
        }

        public void Display()
        {
            this.priorityQueue.Print();
        }

        private void Add(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new NullReferenceException("");
            var trieNode = trie.Add(word);
            var topNodeInPQ = priorityQueue.Top();

            if (!priorityQueue.isFull() && trieNode.PQIndex < 0)
            {
                int index = priorityQueue.Enqueue(new KMostFrequentPQNode<String>(word, trieNode.count, trieNode));
                trieNode.PQIndex = index;
            }
            else if (trieNode.PQIndex >= 0)
            {
                trieNode.PQIndex = priorityQueue.UpdatePriority(trieNode.PQIndex, trieNode.count, trieNode);
            }
            else if (priorityQueue.isFull() && topNodeInPQ != null && trieNode.PQIndex == -1 && trieNode.count > topNodeInPQ.priority)
            {
                var nodeDeleted = priorityQueue.Dequeue();
                trie.RemovePQIndex(nodeDeleted.value);
                int index = priorityQueue.Enqueue(new KMostFrequentPQNode<String>(word, trieNode.count, trieNode));
                trieNode.PQIndex = index;
            }
        }
    }
}
