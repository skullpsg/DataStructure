using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;


namespace Datastructure.Tree.Problems.SumAllNodesInTree
{
    [TestFixture]
    public class SumAllNodesInTest
    {
        [Test]
        public void ShouldReturnSumUsingRecussion()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var sumAllNode = new SumAllNodesInTree();
            var sum = sumAllNode.UsingRecursion(rootNode);
            Assert.AreEqual(36, sum);
        }

        [Test]
        public void ShouldReturnSumUsingNonRecussion()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var sumAllNode = new SumAllNodesInTree();
            var sum = sumAllNode.UsingNonRecursion(rootNode);
            Assert.AreEqual(36, sum);
        }

    }
}
