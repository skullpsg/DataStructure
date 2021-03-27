using Datastructure.Common;
using Datastructure.Tree.Model;
using Datastructure.Tree.Problems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Test
{
    [TestFixture]
    public class MaxSumInLevelOfTreeTest
    {

        [Test]
        public void FindShouldReturnMaxSumInLevelOfTree()
        {
            TreeDSNode rootNode = TreeTestData.GetComplexTreeRootNode();
            MaxSumInLevelOfTree maxSumInLevelOfTree = new MaxSumInLevelOfTree();
            var maxSum = maxSumInLevelOfTree.Find(rootNode);
            Assert.AreEqual(15, maxSum);
        }
    }
}
