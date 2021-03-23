using Datastructure;
using Datastructure.LinkedList;
using Datastructure.Tree;
using Datastructure.Tree.Model;
using Moq;
using NUnit.Framework;

namespace Datastructure.Tree.Test
{

    [TestFixture]
    public class TreeDSTest
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
            TreeDSNode rootNode = GetTree();

            TreeDS tree = new TreeDS(rootNode);
            var actual = tree.GetNodeUsingRecursion(rootNode, 4);
            Assert.AreEqual(actual.Value, 4);

            var actualNodeFor6 = tree.GetNodeUsingRecursion(rootNode, 6);
            Assert.AreEqual(actualNodeFor6.Value, 6);

            var actualRootNode = tree.GetNodeUsingRecursion(rootNode, 1);
            Assert.AreEqual(actualRootNode.Value, 1);

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
