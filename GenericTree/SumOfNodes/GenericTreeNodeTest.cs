using Datastructure.GenericTree.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.GenericTree.SumOfNodes
{
    [TestFixture]
    public class GenericTreeNodeTest
    {
        [Test]
        public void ShouldReturnSum()
        {
            var rootNode = new GenericTreeNode(1);
            var childOfRootWithValue2 = new GenericTreeNode(2);
            var SiblingOfFirstChild = new GenericTreeNode(3);
            var SiblingOfFirstChild2 = new GenericTreeNode(4);
            var ChildOfNode1 = new GenericTreeNode(5);
            SiblingOfFirstChild2.Child = ChildOfNode1;
            SiblingOfFirstChild.Sibiling = SiblingOfFirstChild2;
            childOfRootWithValue2.Sibiling = SiblingOfFirstChild;
            rootNode.Child = childOfRootWithValue2;
            SumOfNodes sum = new SumOfNodes();
            var sumValue = sum.Find(rootNode);
            Assert.AreEqual(15, sumValue);
        }
    }
}
