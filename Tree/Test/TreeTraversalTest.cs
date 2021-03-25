using Datastructure.Common;
using Datastructure.Tree.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Datastructure.Tree.Test
{

    [TestFixture]
    public class TreeTraversalTest
    {

        [Test]
        public void ShouldPrintTreeInPreOrder()
        {
            var expectedOutputs = new List<int>() { 1, 2, 4, 5, 3, 6 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.PreOrderTraversal();
        }

        [Test]
        public void ShouldPrintTreeInInOrder()
        {
            var expectedOutputs = new List<int>() { 4, 5, 2, 6, 3, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.InOrderTraversal();
        }

        [Test]
        public void ShouldPrintTreeInPostOrder()
        {
            var expectedOutputs = new List<int>() { 4, 5, 2, 6, 3, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.PostOrderTraversal();
        }

        [Test]
        public void ShouldPrintTreeInLevelOrder()
        {
            var expectedOutputs = new List<int>() {1,2,3,4,5,6 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.LevelOrderTraversal();
        }


    }
}
