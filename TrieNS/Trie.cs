using Datastructure.TrieNS.Model;
using System;

namespace Datastructure.TrieNS
{
    public class Trie<T> where T : TrieNodeBase, new()
    {
        protected T root;

        public Trie()
        {

        }
        public Trie(T node)
        {
            this.root = node;
        }

        public T Add(string str)
        {
            var current = root;

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                if (current.nodes[c] == null)
                {
                    T newNode = CreateNode(c);
                    current.nodes[c] = newNode;
                    current = newNode;
                }
                else
                {
                    current = (T)current.nodes[c];
                }
                if (i + 1 == str.Length)
                {
                    current.count++;
                    current.isEnd = true;
                }
            }
            return current;
        }

        private T CreateNode(char ch)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { ch });
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
                    current = (T)current.nodes[c];
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
