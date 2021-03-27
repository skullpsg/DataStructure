using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.DiameterOfTree
{
    [TestFixture]
    public class DiameterOfTreeTest
    {
        public DiameterOfTreeTest()
        {
        }

        [Test]
        public void ShouldReturnDiameterOfTree()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            DiameterOfTree diameterOfTree = new DiameterOfTree();
            var diameter = diameterOfTree.Find(rootNode);
            Assert.AreEqual(6, diameter);
        }
    }
}
