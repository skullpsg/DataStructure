using Datastructure.Common;
using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
{
    public class FindMaxElement : IAlgorithm<TreeDSNode>
    {
        public IConsoleWriter console = null;

        public FindMaxElement(IConsoleWriter console = null)
        {
            this.console = console;
        }


        public TreeDSNode NonRecursion(TreeDSNode root)
        {
            throw new NotImplementedException();
        }

        public TreeDSNode Recursion(TreeDSNode root)
        {
            TreeDSNode maxNode = root;
            TreeDSNode leftMaxNode = null, rightMaxNode = null;
            if (root == null) return null;
            if (root.isLeftNodeNull() && root.isRightNodeNull()) return root;
            if (root.isLeftNodeAvailable())
            {
                leftMaxNode = Recursion(root.Left);
                if (leftMaxNode?.Value > maxNode.Value)
                    maxNode = leftMaxNode;
            }
            if (root.isRightNodeAvailable())
            {
                rightMaxNode = Recursion(root.Right);
                if (rightMaxNode?.Value > maxNode.Value)
                    maxNode = rightMaxNode;
            }

            return maxNode;
        }
    }
}
