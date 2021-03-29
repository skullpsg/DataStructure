using Datastructure.Common;
using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.SumAllNodesInTree
{
    public class SumAllNodesInTree : IAlgorithm<TreeDSNode, int>
    {
        public int UsingNonRecursion(TreeDSNode root)
        {
            int sum = 0;
            TreeDSNode currentNode = null;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();

                if (currentNode != null)
                    sum += currentNode.Value;

                if (currentNode.isLeftNodeAvailable())
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.isRightNodeAvailable())
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
            return sum;
        }

        public int UsingRecursion(TreeDSNode root)
        {
            if (root == null)
                return 0;

            if (root.isLeftNodeNull() && root.isRightNodeAvailable())
                return root.Value;

            return root.Value + UsingRecursion(root.Left) + UsingRecursion(root.Right);

        }
    }
}
