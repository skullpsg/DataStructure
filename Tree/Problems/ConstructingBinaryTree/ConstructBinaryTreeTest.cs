using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.StructuralIdentificationNS;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.ConstructingBinaryTree
{
    [TestFixture]
    class ConstructBinaryTreeTest
    {
        [Test]
        public void ShouldConstructTreeUsingInOrderAndPreOrder()
        {
            TreeDSNode expectedTree = TreeTestData.GetComplexTreeRootNode();
            ConstructBinaryTree constructBinaryTree = new ConstructBinaryTree();
            List<int> inOrder = new List<int> { 4, 2, 7, 5, 8, 1, 6, 3 };
            List<int> preOrder = new List<int> { 1, 2, 4, 5, 7, 8, 3, 6 };
            var actualTree = constructBinaryTree.FromInorderAndPreOrder(inOrder, preOrder, 0, inOrder.Count-1);
            StructuralIdentification structuralIdentification = new StructuralIdentification();
            var result = structuralIdentification.ValidateWithValue(actualTree, expectedTree);
            Assert.IsTrue(result);
        }
}
}
