using Datastructure.Common;
using Datastructure.Tree.Model;
using System.Collections.Generic;

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
            TreeDSNode currentNode = null;
            TreeDSNode expectedNode = null;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode.Value == valueToFind)
                {
                    expectedNode = currentNode;
                    break;
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
            return expectedNode;
        }


    }
}
