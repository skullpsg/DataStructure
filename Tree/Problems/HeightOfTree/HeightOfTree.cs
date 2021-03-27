using Datastructure.Common;
using Datastructure.Tree.Model;
using System.Collections.Generic;

namespace Datastructure.Tree.Problems.HeightOfTree
{
    public class HeightOfTree : IAlgorithm<TreeDSNode, int>
    {
        public int UsingNonRecursion(TreeDSNode root)
        {
            if (root == null)
                return 0;
            var currentNode = root;
            int height = 0;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode == null)
                {
                    if (queue.Count > 1)
                    {
                        queue.Enqueue(null);
                    }
                    height++;
                    continue;
                }
                if (currentNode.isLeftNodeAvailable())
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.isRightNodeAvailable())
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
            return height;
        }

        public int UsingRecursion(TreeDSNode root)
        {
            int leftHeight = 0, rightHeight = 0;
            if (root == null)
                return 0;
            if (root.isLeftNodeAvailable())
            {
                leftHeight = UsingRecursion(root.Left);
            }
            if (root.isRightNodeAvailable())
            {
                rightHeight = UsingRecursion(root.Right);
            }
            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }
    }
}
