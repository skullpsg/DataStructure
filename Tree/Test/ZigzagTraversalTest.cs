using Datastructure.Common;
using Datastructure.Tree.Model;
using Datastructure.Tree.Problems;
using NUnit.Framework;
using System.Collections.Generic;

namespace Datastructure.Tree.Test
{

    [TestFixture]
    public class ZigzagTraversalTest
    {
        [Test]
        public void ShouldPrintTreeNodesInZigZagTraversal()
        {
            var expectedOutputs = new List<int>() { 1, 3, 2, 4, 5, 6 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            ZigZagTraversal zigzagTraversal = new ZigZagTraversal(rootNode, writerMock);
            zigzagTraversal.Travel();
        }
    }
}
