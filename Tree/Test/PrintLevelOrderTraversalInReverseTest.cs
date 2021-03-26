using Datastructure.Common;
using Datastructure.Tree.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace Datastructure.Tree.Test
{
    [TestFixture]
    public class PrintLevelOrderTraversalInReverseTest
    {
        [Test]
        public void ShouldPrintTreeInLevelOrder()
        {
            var expectedOutputs = new List<int>() { 6, 5, 4, 3, 2, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            var rootNode = TreeTestData.GetSimpleTreeRootNode();
            var levelOrderTraversalInReverse = new LevelOrderTraversalInReverse(writerMock);
            levelOrderTraversalInReverse.Print(rootNode);
        }

        [Test]
        public void ShouldPrintTreeInLevelOrderForComplexTree()
        {
            var expectedOutputs = new List<int>() { 8, 7, 6, 5, 4, 3, 2, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var levelOrderTraversalInReverse = new LevelOrderTraversalInReverse(writerMock);
            levelOrderTraversalInReverse.Print(rootNode);
        }

    }
}
