using Datastructure.Tree.Model;
using System.Collections.Generic;

namespace Datastructure.Tree.Problems.MaxSumInLevelOfTree
{
    public class MaxSumInLevelOfTree
    {

        public int Find(TreeDSNode root)
        {
            var currentNode = root;
            int maxSum = 0, levelSum = 0;
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
                        levelSum = 0;
                        queue.Enqueue(null);
                    }
                    if (levelSum > maxSum)
                    {
                        maxSum = levelSum;
                    }
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
                levelSum += currentNode.Value;
            }
            return maxSum;
        }
    }
}
