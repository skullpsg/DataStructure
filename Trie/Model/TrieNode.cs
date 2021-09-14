using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Trie.Model
{
    public class TrieNode
    {
        public Dictionary<int, TrieNode> nodes;
        public Boolean isEnd;
        public char ch;
        private string chars = "abcdefghijklmnopqrstuvwxyz1234567890";
        public TrieNode(char ch)
        {
            this.ch = ch;
            this.nodes = new Dictionary<int, TrieNode>();
            foreach (var c in chars)
            {
                this.nodes[c] = null;
            }
        }
    }
}
