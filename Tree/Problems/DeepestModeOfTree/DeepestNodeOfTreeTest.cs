using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.DeepestModeOfTree
{
    [TestFixture]
    public class DeepestNodeOfTreeTest
    {

        [Test]
        public void ShouldReturnDeepestNode()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            DeepestNodeOfTree deepestNodeOfTree = new DeepestNodeOfTree();
            var deepestNode = deepestNodeOfTree.Find(rootNode);
            Assert.AreEqual(8, deepestNode.Value); 
        }
    }
}
