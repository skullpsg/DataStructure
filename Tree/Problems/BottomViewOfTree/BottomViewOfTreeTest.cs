using Datastructure.Common;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.BottomViewOfTree
{
    [TestFixture]
    class BottomViewOfTreeTest
    {
        [Test]
        public void ShouldPrintBottomViewOfTree()
        {
            var expectedOutputs = new List<String>() { "4", "7", "6", "8", "3" };
            IConsoleWriter writerMock = MockWriter.GetInstanceForString(expectedOutputs);
            var rootNode = TreeTestData.GetSimpleTreeRootNode();
            BottomViewOfTree bottomViewOfTree = new BottomViewOfTree(writerMock);
            bottomViewOfTree.view(rootNode, 0);
        }
    }
}
