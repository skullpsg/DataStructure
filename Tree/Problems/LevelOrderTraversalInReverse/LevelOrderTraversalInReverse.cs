using Datastructure.Tree.Model;
using System.Collections.Generic;

namespace Datastructure.Tree.Problems.LevelOrderTraversalInReverse
{
    public class LevelOrderTraversalInReverse
    {
        public IConsoleWriter console = null;

        public LevelOrderTraversalInReverse(IConsoleWriter console = null)
        {
            this.console = console;
        }

        public void Print(TreeDSNode root)
        {
            TreeDSNode currentNode = null;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            var stack = new Stack<TreeDSNode>();
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                stack.Push(currentNode);
                if (currentNode.isLeftNodeAvailable())
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.isRightNodeAvailable())
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            while (stack.Count > 0)
            {
                var nodeToPrint = stack.Pop();
                PrintNode(nodeToPrint);
            }
        }

        private void PrintNode(TreeDSNode node)
        {
            if (node == null)
                return;

            if (console != null)
                console.WriteLine(node.Value);
            else
                System.Console.Out.WriteLine(node.Value);
        }

    }
}
