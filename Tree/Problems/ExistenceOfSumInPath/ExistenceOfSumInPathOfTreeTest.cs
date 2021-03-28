using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.ExistenceOfSumInPath
{
    [TestFixture]
    class ExistenceOfSumInPathOfTreeTest
    {
        [Test]
        public void ShouldReturnTrueIfSumExistInPathOfTree()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var existenceOfSumInPathOfTree = new ExistenceOfSumInPathOfTree();
            var isExist = existenceOfSumInPathOfTree.Check(rootNode, 15);
            Assert.AreEqual(true, isExist);
        }

    }
}
