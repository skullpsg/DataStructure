using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.LeastCommonAncestor
{
    [TestFixture]
    public class LeastCommonAncestorTest
    {
        [Test]
        public void ShouldReturnLeastCommonAncestor()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var nodeWithValue4 = TreeDSNode.Create(4);
            var nodeWithValue5 = TreeDSNode.Create(5);
            var nodeWithValue3 = TreeDSNode.Create(3);
            LeastCommonAncestor leastCommonAncestor = new LeastCommonAncestor();
            var actualLCA = leastCommonAncestor.Find(rootNode, nodeWithValue4, nodeWithValue5);
            Assert.AreEqual(2, actualLCA.Value);

            actualLCA = leastCommonAncestor.Find(rootNode, nodeWithValue4, nodeWithValue3);
            Assert.AreEqual(1, actualLCA.Value);
        }

        [Test]
        public void ShouldReturnLeastCommonAncestorWith12Nodes()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNodeWith12Nodes();
            var nodeWithValue10 = TreeDSNode.Create(10);
            var nodeWithValue12 = TreeDSNode.Create(12);
            LeastCommonAncestor leastCommonAncestor = new LeastCommonAncestor();
            var actualLCA = leastCommonAncestor.Find(rootNode, nodeWithValue10, nodeWithValue12);
            Assert.AreEqual(10, actualLCA.Value);
        }
    }
}
