using Datastructure.TrieNS;
using Datastructure.TrieNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.StringAlgo.kMostFrequesntWord.Model
{
    public class KMostTrie<T> : Trie<T> where T : kMostFrequencyTrieNode, new()
    {
        public KMostTrie(T node)
        {
            this.root = node;
        }

        public T RemovePQIndex(string str)
        {
            var current = root;

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                current = (T)current.nodes[c];
                if (i + 1 == str.Length)
                {
                    current.PQIndex = -1;
                }
            }
            return current;
        }
    }
}
