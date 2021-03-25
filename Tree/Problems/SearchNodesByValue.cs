using Datastructure.Common;
using Datastructure.Tree.Model;


namespace Datastructure.Tree.Problems
{
    public class SearchNodesByValue : IAlgorithm<TreeDSNode>
    {
        public int valueToFind { get; set; } = 0;
        public SearchNodesByValue(int valueToFind)
        {
            this.valueToFind = valueToFind;
        }


        public TreeDSNode Recursion(TreeDSNode root)
        {
            if (root == null)
                return null;

            if (root.Value == valueToFind)
                return root;

            if (root.isLeftNodeAvailable())
            {
                var node = Recursion(root.Left);
                if (node != null)
                    return node;
            }
            if (root.isRightNodeAvailable())
            {
                var node = Recursion(root.Right);
                if (node != null)
                    return node;
            }

            return null;
        }
        public TreeDSNode NonRecursion(TreeDSNode root)
        {
            return null;
        }


    }
}
