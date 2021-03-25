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
    public class FindMaxNodeTest
    {
        [Test]
        public void ShouldReturnMaxNodeInRecursion()
        {

            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            FindMaxElement findMaxNode = new FindMaxElement();
            var maxNode = findMaxNode.Recursion(rootNode);
            Assert.AreEqual(6, maxNode.Value);
        }

        [Test]
        public void ShouldReturnMaxNodeInNonRecursion()
        {
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            FindMaxElement findMaxNode = new FindMaxElement();
            var maxNode = findMaxNode.NonRecursion(rootNode);
            Assert.AreEqual(6, maxNode.Value);
        }
    }
}
