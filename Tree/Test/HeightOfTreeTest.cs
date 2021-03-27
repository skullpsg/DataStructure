using Datastructure.Common;
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
