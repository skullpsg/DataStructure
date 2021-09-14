using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Trie
{
    [TestFixture]
    public class TrieTest
    {
        [Test]
        public void ShouldReturnTrueIfWordFound()
        {
            Trie trie = new Trie();
            trie.Add("sample");
            trie.Add("sam");
            trie.Add("sam1");
            trie.Add("sam123");
            trie.Add("sam12345");
            Assert.IsFalse(trie.IsWordFound("sam2"));
            Assert.IsTrue(trie.IsWordFound("sam123"));
        }
    }
}
