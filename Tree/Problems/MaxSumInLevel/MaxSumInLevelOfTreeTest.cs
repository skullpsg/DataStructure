using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.MaxSumInLevelOfTree
{
    [TestFixture]
    public class MaxSumInLevelOfTreeTest
    {

        [Test]
        public void FindShouldReturnMaxSumInLevelOfTree()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            MaxSumInLevelOfTree maxSumInLevelOfTree = new MaxSumInLevelOfTree();
            var maxSum = maxSumInLevelOfTree.Find(rootNode);
            Assert.AreEqual(15, maxSum);
        }
    }
}
