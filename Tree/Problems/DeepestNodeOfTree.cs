using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
{
    public class DeepestNodeOfTree
    {
        public DeepestNodeOfTree()
        {
        }

        public TreeDSNode Find(TreeDSNode root)
        {
            TreeDSNode currentNode = null;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode.isLeftNodeAvailable())
                    queue.Enqueue(currentNode.Left);
                if (currentNode.isRightNodeAvailable())
                    queue.Enqueue(currentNode.Right);
            }
            return currentNode;
        }
    }
}
