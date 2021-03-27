using Datastructure.Tree.Model;

namespace Datastructure.Tree.Problems.StructuralIdentification
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
    }
}
