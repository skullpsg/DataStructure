using Datastructure.TrieNS.Model;
using NUnit.Framework;

namespace Datastructure.TrieNS
{
    [TestFixture]
    public class TrieTest
    {
        [Test]
        public void ShouldReturnTrueIfWordFound()
        {
            Trie<TrieNode> trie = new Trie<TrieNode>(new TrieNode('*'));
            trie.Add("sample");
            trie.Add("sam");
            trie.Add("sam1");
            trie.Add("sam123");
            trie.Add("sam12345");
            Assert.IsFalse(trie.IsWordFound("sam2"));
            Assert.IsTrue(trie.IsWordFound("sam123"));
            var actualResponse = trie.Add("sam123");
            Assert.AreEqual(actualResponse.count, 2);
        }
    }
}
