using Datastructure;
using Datastructure.Common;
using Datastructure.LinkedList;
using Datastructure.Tree;
using Datastructure.Tree.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Datastructure.Tree.Test
{

    [TestFixture]
    public class TreeDSTest
    {

        [Test]
        public void ShouldPrintTreeInPreOrder()
        {
            var expectedOutputs = new List<int>() { 1, 2, 3 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);

            LinkedListDS linkedList = new LinkedListDS(writerMock);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            linkedList.Result();
        }

        [Test]
        public void ShouldReturnNodeByValue()
        {
            TreeDSNode rootNode = GetTree();

            // finding node which is available in left side of the tree
            TreeDS tree = new TreeDS(rootNode);
            var actual = tree.GetNodeUsingRecursion(rootNode, 4);
            Assert.AreEqual(actual.Value, 4);

            // finding node which is available in right side of the tree
            var actualNodeFor6 = tree.GetNodeUsingRecursion(rootNode, 6);
            Assert.AreEqual(actualNodeFor6.Value, 6);

            // finding node which is available in root of the tree
            var actualRootNode = tree.GetNodeUsingRecursion(rootNode, 1);
            Assert.AreEqual(actualRootNode.Value, 1);

            // finding node which is not available in the tree
            var nullValueForNotFound = tree.GetNodeUsingRecursion(rootNode, 99);
            Assert.AreEqual(nullValueForNotFound, null);

        }

        private TreeDSNode GetTree()
        {
            TreeDSNode nodeWithValue4, nodeWithValue6, root;
            nodeWithValue4 = TreeDSNode.Create(4);
            var nodeWithValue5 = TreeDSNode.Create(5);
            nodeWithValue6 = TreeDSNode.Create(6);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue4, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, nodeWithValue6, null);
            root = new TreeDSNode(1, nodeWithValue2, nodeWithValue3);
            return root;
        }
    }
}
