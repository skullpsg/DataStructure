using Datastructure.Common;
using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
{
    class TreeSize : IAlgorithm<TreeDSNode, int>
    {
        public int NonRecursion(TreeDSNode root)
        {
            var currentNode = root;
            int size = 0;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode != null)
                {
                    size++;
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
            return size;
        }

        public int Recursion(TreeDSNode root)
        {
            if (root == null)
                return 0;

            return Recursion(root.Left) + Recursion(root.Right) + 1;
        }
    }
}
