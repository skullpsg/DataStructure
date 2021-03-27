using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
{
    public class TreeNodesType
    {
        delegate bool NodeTypeFilter(TreeDSNode node);
        public int FullNodesCount(TreeDSNode root)
        {
            return GetNodesCount(root, new NodeTypeFilter(isFullNode));
        }

        public int LeaftNodesCount(TreeDSNode root)
        {
            return GetNodesCount(root, new NodeTypeFilter(isLeafNode));
        }

        public int HalfNodesCount(TreeDSNode root)
        {
            return GetNodesCount(root, new NodeTypeFilter(isHalfNode));
        }

        private int GetNodesCount(TreeDSNode root, NodeTypeFilter filter)
        {
            var currentNode = root;
            var strictNodesCount = 0;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (filter(currentNode))
                {
                    strictNodesCount++;
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
            return strictNodesCount;
        }

        private bool isFullNode(TreeDSNode currentNode)
        {
            return currentNode.isLeftNodeAvailable() && currentNode.isRightNodeAvailable();
        }

        private bool isLeafNode(TreeDSNode currentNode)
        {
            return currentNode.isLeftNodeNull() && currentNode.isRightNodeNull();
        }

        private bool isHalfNode(TreeDSNode currentNode)
        {
            return (currentNode.isLeftNodeAvailable() && currentNode.isRightNodeNull()) || (currentNode.isRightNodeAvailable() && currentNode.isLeftNodeNull());
        }
    }
}
