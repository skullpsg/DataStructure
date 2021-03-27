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
