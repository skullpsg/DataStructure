using Datastructure.Common;
using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;

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
            if (root == null)
            {
                throw new NullReferenceException();
            }

            TreeDSNode currentNode = null;
            var maxNode = root;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode.Value > maxNode.Value)
                {
                    maxNode = currentNode;
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
            return maxNode;
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
