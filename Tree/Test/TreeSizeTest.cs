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
    public class TreeSizeTest
    {
        [Test]
        public void ShouldReturnSizeUsingRecursion()
        {

            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            var treeSize = new TreeSize();
            var actualSize = treeSize.Recursion(rootNode);
            Assert.AreEqual(6, actualSize);
        }

        [Test]
        public void ShouldReturnSizeUsingNonRecursion()
        {
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            var treeSize = new TreeSize();
            var actualSize = treeSize.NonRecursion(rootNode);
            Assert.AreEqual(6, actualSize);
        }
    }
}
