using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.TreeSize
{
    [TestFixture]
    public class TreeSizeTest
    {
        [Test]
        public void ShouldReturnSizeUsingRecursion()
        {

            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            var treeSize = new TreeSize();
            var actualSize = treeSize.UsingRecursion(rootNode);
            Assert.AreEqual(6, actualSize);
        }

        [Test]
        public void ShouldReturnSizeUsingNonRecursion()
        {
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            var treeSize = new TreeSize();
            var actualSize = treeSize.UsingNonRecursion(rootNode);
            Assert.AreEqual(6, actualSize);
        }
    }
}
