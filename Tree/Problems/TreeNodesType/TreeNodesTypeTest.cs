using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.TreeNodesType
{
    [TestFixture]
    class TreeNodesTypeTest
    {
        [Test]
        public void ShouldReturnFullNodesCount()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            TreeNodesType treeNodesType = new TreeNodesType();
            var fullNodesCount = treeNodesType.FullNodesCount(rootNode);
            Assert.AreEqual(3, fullNodesCount);
        }

        [Test]
        public void ShouldReturnHalfNodesCount()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            TreeNodesType treeNodesType = new TreeNodesType();
            var halfNodesCount = treeNodesType.HalfNodesCount(rootNode);
            Assert.AreEqual(1, halfNodesCount);
        }

        [Test]
        public void ShouldReturnLeafNodesCount()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            TreeNodesType treeNodesType = new TreeNodesType();
            var leafNodesCount = treeNodesType.LeaftNodesCount(rootNode);
            Assert.AreEqual(4, leafNodesCount);
        }
    }
}
