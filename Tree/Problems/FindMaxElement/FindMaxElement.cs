using Datastructure.Common;
using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;

namespace Datastructure.Tree.Problems.FindMaxElement
{
    public class FindMaxElement : IAlgorithm<TreeDSNode,TreeDSNode>
    {
        public IConsoleWriter console = null;

        public FindMaxElement(IConsoleWriter console = null)
        {
            this.console = console;
        }


        public TreeDSNode UsingNonRecursion(TreeDSNode root)
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

        public TreeDSNode UsingRecursion(TreeDSNode root)
        {
            TreeDSNode maxNode = root;
            TreeDSNode leftMaxNode = null, rightMaxNode = null;
            if (root == null) return null;
            if (root.isLeftNodeNull() && root.isRightNodeNull()) return root;
            if (root.isLeftNodeAvailable())
            {
                leftMaxNode = UsingRecursion(root.Left);
                if (leftMaxNode?.Value > maxNode.Value)
                    maxNode = leftMaxNode;
            }
            if (root.isRightNodeAvailable())
            {
                rightMaxNode = UsingRecursion(root.Right);
                if (rightMaxNode?.Value > maxNode.Value)
                    maxNode = rightMaxNode;
            }

            return maxNode;
        }
    }
}
