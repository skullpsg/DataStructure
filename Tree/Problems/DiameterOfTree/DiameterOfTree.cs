using Datastructure.Tree.Model;
using System;

namespace Datastructure.Tree.Problems.DiameterOfTree
{
    public class DiameterOfTree
    {
        public DiameterOfTree()
        {
        }

        public int Find(TreeDSNode root)
        {
            if (root == null)
                return 0;

            var leftHeight = HeightOfTree(root.Left);
            var rightHeight = HeightOfTree(root.Right);

            var leftDiameter = Find(root.Left);
            var rightDiameter = Find(root.Right);

            return Math.Max(1 + leftHeight + rightHeight, Math.Max(leftDiameter, rightDiameter));
        }

        public int HeightOfTree(TreeDSNode root)
        {
            int leftHeight = 0, rightHeight = 0;
            if (root == null)
                return 0;
            if (root.isLeftNodeAvailable())
            {
                leftHeight = HeightOfTree(root.Left);
            }
            if (root.isRightNodeAvailable())
            {
                rightHeight = HeightOfTree(root.Right);
            }
            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }
    }
}
