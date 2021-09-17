using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.TrieNS.Model
{
    public class TrieNodeBase
    {
        public Dictionary<int, TrieNodeBase> nodes;
        public Boolean isEnd;
        public char ch;
        public int count;
        private string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

        public TrieNodeBase()
        {
            InitializeNodes();
        }
        public TrieNodeBase(char ch)
        {
            this.ch = ch;
            InitializeNodes();
        }

        private void InitializeNodes()
        {
            this.nodes = new Dictionary<int, TrieNodeBase>();
            foreach (var c in chars)
            {
                this.nodes[c] = null;
            }
        }
    }
}
