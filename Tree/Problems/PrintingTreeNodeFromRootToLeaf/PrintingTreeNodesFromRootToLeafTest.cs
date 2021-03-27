using Datastructure.Common;
using Datastructure.Tree.Problems;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.PrintingTreeNodesFromRootToLeaf
{
    [TestFixture]
    class PrintingTreeNodesFromRootToLeafTest
    {
        [Test]
        public void ShouldPrintAllNodeFromRootToLeaf()
        {
            var expectedOutputs = new List<String>() { "Tree path: 1,2,4", "Tree path: 1,2,5", "Tree path: 1,3,6" };
            IConsoleWriter writerMock = MockWriter.GetInstanceForString(expectedOutputs);
            var rootNode = TreeTestData.GetSimpleTreeRootNode();
            PrintingTreeNodesFromRootToLeaf tree = new PrintingTreeNodesFromRootToLeaf(writerMock);
            tree.Print(rootNode, new List<int>());
        }
    }
}
