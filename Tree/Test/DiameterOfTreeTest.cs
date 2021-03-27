using Datastructure.Tree.Model;
using Datastructure.Tree.Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Test
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
