using Datastructure.Tree.Model;

namespace Datastructure.Tree.Problems.StructuralIdentificationNS
{
    public class StructuralIdentification
    {
        public bool Validate(TreeDSNode rootOfFirstTree, TreeDSNode rootOfSecondTree)
        {
            if (rootOfFirstTree == null && rootOfSecondTree == null)
                return true;

            if (rootOfFirstTree != null && rootOfSecondTree == null)
                return false;
            else if (rootOfFirstTree == null && rootOfSecondTree != null)
                return false;

            return Validate(rootOfFirstTree.Left, rootOfSecondTree.Left) && Validate(rootOfFirstTree.Right, rootOfSecondTree.Right);
        }

        public bool ValidateWithValue(TreeDSNode rootOfFirstTree, TreeDSNode rootOfSecondTree)
        {
            if (rootOfFirstTree == null && rootOfSecondTree == null)
                return true;

            if (rootOfFirstTree != null && rootOfSecondTree == null)
                return false;

            else if (rootOfFirstTree == null && rootOfSecondTree != null)
                return false;

            return rootOfFirstTree.Value == rootOfSecondTree.Value && Validate(rootOfFirstTree.Left, rootOfSecondTree.Left) && Validate(rootOfFirstTree.Right, rootOfSecondTree.Right);
        }
    }
}
