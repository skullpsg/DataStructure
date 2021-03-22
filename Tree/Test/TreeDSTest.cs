using Datastructure;
using Datastructure.LinkedList;
using Datastructure.Tree;
using Datastructure.Tree.Model;
using Moq;
using NUnit.Framework;

namespace DatastructureTest.Tree
{

    [TestFixture]
    class TreeDSTest
    {

        [Test]
        public void PrintTreeInPreOrder()
        {

            var seq = new MockSequence();
            TreeDSNode treeNode = TreeDSNode.Create(1);


            var writerMock = new Mock<IConsoleWriter>(MockBehavior.Strict);
            LinkedListDS linkedList = new LinkedListDS(writerMock.Object);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            writerMock.InSequence(seq).Setup(m => m.WriteLine(1));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(2));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(3));

            linkedList.Result();
        }

        [Test]
        public void GetNodeByValue()
        {
            var nodeWithValue4 = TreeDSNode.Create(4);
            var nodeWithValue5 = TreeDSNode.Create(5);
            var nodeWithValue6 = TreeDSNode.Create(6);

            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue4, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, nodeWithValue6, null);
            TreeDSNode root = new TreeDSNode(1, nodeWithValue2, nodeWithValue3);

            TreeDS tree = new TreeDS(root);
            var actual = tree.GetNodeUsingRecursion(root, 4);
            Assert.AreSame(actual, nodeWithValue4);

            var actualNodeFor6 = tree.GetNodeUsingRecursion(root, 6);
            Assert.AreSame(actualNodeFor6, nodeWithValue6);

            var actualRootNode = tree.GetNodeUsingRecursion(root, 1);
            Assert.AreSame(actualRootNode, root);

            var nullValueForNotFound = tree.GetNodeUsingRecursion(root, 99);
            Assert.AreSame(nullValueForNotFound, null);

        }

    }
}
