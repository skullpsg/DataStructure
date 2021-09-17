using Datastructure.TrieNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.StringAlgo.kMostFrequesntWord.Model
{
    public class kMostFrequencyTrieNode : TrieNodeBase
    {
        public int PQIndex = -1;

        public kMostFrequencyTrieNode() : base()
        {

        }
        public kMostFrequencyTrieNode(char ch) : base(ch)
        {
        }
        public kMostFrequencyTrieNode(char ch, int index) : base(ch)
        {
            this.PQIndex = index;
        }
    }
}
