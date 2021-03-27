using Datastructure.Common;
using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.HeightOfTree
{
    [TestFixture]
    public class HeightOfTreeTest
    {
        [Test]
        public void ShouldReturnHeightUsinrRecussion()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            IAlgorithm<TreeDSNode, int> heightOfTree = new HeightOfTree();
            var height = heightOfTree.UsingRecursion(rootNode);
            Assert.AreEqual(4, height);
        }

        [Test]
        public void ShouldReturnHeightUsinrNonRecussion()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            IAlgorithm<TreeDSNode, int> heightOfTree = new HeightOfTree();
            var height = heightOfTree.UsingNonRecursion(rootNode);
            Assert.AreEqual(4, height);
        }

    }
}
