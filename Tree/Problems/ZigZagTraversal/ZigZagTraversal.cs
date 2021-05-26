using Datastructure.Tree.Model;
using System;
using System.Collections;

namespace Datastructure.Tree.Problems.ZigZagTraversal
{
    public class ZigZagTraversal
    {
        public TreeDSNode root = null;
        public IConsoleWriter console = null;

        public ZigZagTraversal(TreeDSNode rootNode, IConsoleWriter console = null)
        {
            this.console = console;
            if (rootNode == null)
                throw new NullReferenceException();
            root = rootNode;
        }

        public void Travel()
        {
            Queue queue = new Queue();
            queue.Enqueue(this.root);
            queue.Enqueue(null);
            bool isLeftToRight = false;
            while (queue.Count > 1 )
            {
                var currentNode = (TreeDSNode)queue.Dequeue();
                if (currentNode == null)
                {
                       isLeftToRight = !isLeftToRight;
                        queue.Enqueue(null);
                        continue;
                }
                else
                {
                    if (isLeftToRight)
                    {
                        if (currentNode.isLeftNodeAvailable())
                        {
                            queue.Enqueue(currentNode.Left);
                        }
                        if (currentNode.isRightNodeAvailable())
                        {
                            queue.Enqueue(currentNode.Right);
                        }
                    }
                    else
                    {
                        if (currentNode.isRightNodeAvailable())
                        {
                            queue.Enqueue(currentNode.Right);
                        }
                        if (currentNode.isLeftNodeAvailable())
                        {
                            queue.Enqueue(currentNode.Left);
                        }
                    }
                }
            }


        }
    }
}
