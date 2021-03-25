using Datastructure.Common;
using Datastructure.Tree.Model;
using Datastructure.Tree.Problems;
using NUnit.Framework;

namespace Datastructure.Tree.Test
{
    [TestFixture]
    public class SearchNodeByValueTest
    {
        [Test]
        public void ShouldReturnNodeIfNodeFound()
        {

            var rootNode = TreeTestData.GetSimpleTreeRootNode();

            // finding node which is available in left side of the tree
            IAlgorithm<TreeDSNode> searchNodeByValue = new SearchNodesByValue(4);
            var actual = searchNodeByValue.Recursion(rootNode);
            Assert.AreEqual(actual.Value, 4);

            // finding node which is available in right side of the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 6;
            var actualNodeFor6 = searchNodeByValue.Recursion(rootNode);
            Assert.AreEqual(actualNodeFor6.Value, 6);

            // finding node which is available in root of the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 1;
            var actualRootNode = searchNodeByValue.Recursion(rootNode);
            Assert.AreEqual(actualRootNode.Value, 1);

            // finding node which is not available in the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 99;
            var nullValueForNotFound = searchNodeByValue.Recursion(rootNode);
            Assert.AreEqual(nullValueForNotFound, null);

        }

    }
}
