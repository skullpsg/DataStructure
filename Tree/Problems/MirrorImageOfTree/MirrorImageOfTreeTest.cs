using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;
using Datastructure.Tree.Problems.StructuralIdentificationNS;

namespace Datastructure.Tree.Problems.MirrorImageOfTree
{
    [TestFixture]
    class MirrorImageOfTreeTest
    {
        [Test]
        public void ShouldReturnRootOfMirrorImageTree()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var expectedRootTree = TreeTestData.GetRootNodeOfComplexTreeMirror();
            var MirrorImageTree = new MirrorImageOfTree();
            var actualRoot = MirrorImageTree.Create(rootNode);
            var structuralIdentification = new StructuralIdentification();
            var isIdentical = structuralIdentification.ValidateWithValue(rootNode, expectedRootTree);
            Assert.IsTrue(isIdentical);
        }

        [Test]
        public void ShouldReturnTrueValidateMirrorImageTree()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var mirrorImageRootNode = TreeTestData.GetRootNodeOfComplexTreeMirror();
            var MirrorImageTree = new MirrorImageOfTree();
            var isValid = MirrorImageTree.Validate(rootNode, mirrorImageRootNode);
            Assert.IsTrue(isValid);
        }

        [Test]
        public void ShouldReturnFalseValidateMirrorImageTree()
        {
            var rootNode = TreeTestData.GetComplexTreeRootNode();
            var mirrorImageRootNode = TreeTestData.GetComplexTreeRootNode();
            var MirrorImageTree = new MirrorImageOfTree();
            var isValid = MirrorImageTree.Validate(rootNode, mirrorImageRootNode);
            Assert.IsFalse(isValid);
        }

    }
}
