using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.StructuralIdentification
{
    public class StructuralIdentificationTest
    {
        public void ShouldReturnTrueIfTwoTreeStructuresAreSame()
        {
            TreeDSNode rootNodeOfFirstTree = TreeTestData.GetComplexTreeRootNode();
            TreeDSNode rootNodeOfSecondTree = TreeTestData.GetRootNodeOfComplexTreeWithHighervalue();
            var structuralIdentification = new StructuralIdentification();
            var structuralIdentificationResult = structuralIdentification.Validate(rootNodeOfFirstTree, rootNodeOfSecondTree);
            Assert.AreEqual(true, structuralIdentificationResult);
        }

        public void ShouldReturnFalseIfTwoTreeStructuresAreNotIdentical()
        {
            TreeDSNode rootNodeOfFirstTree = TreeTestData.GetComplexTreeRootNode();
            TreeDSNode rootNodeOfSecondTree = TreeTestData.GetLeftSplayTreeRootNode();
            var structuralIdentification = new StructuralIdentification();
            var structuralIdentificationResult = structuralIdentification.Validate(rootNodeOfFirstTree, rootNodeOfSecondTree);
            Assert.AreEqual(false, structuralIdentificationResult);
        }
    }
}
