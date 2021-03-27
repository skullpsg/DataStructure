using Datastructure.Tree.Model;
using Datastructure.Tree.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
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

            HeightOfTree heightOfTree = new HeightOfTree();
            var leftHeight = heightOfTree.UsingRecursion(root.Left);
            var rightHeight = heightOfTree.UsingRecursion(root.Right);

            var leftDiameter = Find(root.Left);
            var rightDiameter = Find(root.Right);

            return Math.Max(1 + leftHeight + rightHeight, Math.Max(leftDiameter, rightDiameter));
        }
    }
}
