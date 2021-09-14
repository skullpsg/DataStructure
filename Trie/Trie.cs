using Datastructure.Trie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Trie
{
    public class Trie
    {
        private TrieNode root;
        public Trie()
        {
            this.root = new TrieNode('*');
        }

        public void Add(string str)
        {
            var current = root;

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                if (current.nodes[c] == null)
                {
                    var newNode = new TrieNode(c);
                    current.nodes[c] = newNode;
                    current = newNode;
                }
                else
                {
                    current = current.nodes[c];
                }
                if (i + 1 == str.Length)
                {
                    current.isEnd = true;
                }
            }
        }

        public bool IsWordFound(string str)
        {
            var current = root;
            var isWordFound = false;

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                if (current.nodes[c] != null)
                {
                    if (i == str.Length - 1)
                    {
                        isWordFound = current.nodes[c].isEnd;
                        break;
                    }
                    current = current.nodes[c];
                }
                else
                {
                    break;
                }
            }
            return isWordFound;
        }
    }
}
