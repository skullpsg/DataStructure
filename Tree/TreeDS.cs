using Datastructure.Tree.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree
{
    public class TreeDS
    {
        public TreeDSNode root = null;
        public IConsoleWriter console = null;

        public TreeDS(int rootValue, IConsoleWriter console = null)
        {

            this.console = console;
            root = TreeDSNode.Create(rootValue);
        }

        public TreeDS(TreeDSNode rootNode, IConsoleWriter console = null)
        {
            this.console = console;
            if (rootNode == null)
                throw new NullReferenceException();
            root = rootNode;
        }


        public void AddLeft(int nodeValue, int leftOfValue)
        {
            throw new NotImplementedException();
        }

        public void PreOrderTraversal()
        {
            Stack stack = new Stack();
            stack.Push(this.root);
            while (stack.Count != 0)
            {
                var currentNode = (TreeDSNode)stack.Pop();
                PrintNode(currentNode);
                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }
            }
        }

        public void InOrderTraversal()
        {
            Stack stack = new Stack();
            var currentNode = this.root;
            while (stack.Count != 0)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                PrintNode(currentNode);
                currentNode = ((TreeDSNode)stack.Pop()).Right;
            }
        }

        public TreeDSNode GetNodeUsingRecursion(TreeDSNode root, int valueToFind)
        {

            if (root.Value == valueToFind)
                return root;

            if (root.Left != null)
            {
                var node = GetNodeUsingRecursion(root.Left, valueToFind);
                if (node != null)
                    return node;
            }
            if (root.Right != null)
            {
                var node = GetNodeUsingRecursion(root.Right, valueToFind);
                if (node != null)
                    return node;
            }

            return null;
        }

        public void PostOrderTraversal()
        {
            var currentNode = this.root;
            Stack stack = new Stack();
            int lastPrint = 0;
            while (currentNode != null || stack.Count != 0)
            {
                if (currentNode == null)
                {
                    currentNode = (TreeDSNode)stack.Pop();
                }

                if (currentNode.Right?.Value == lastPrint)
                {
                    PrintNode(currentNode);
                    lastPrint = currentNode.Value;
                    currentNode = null;
                }
                else if (currentNode.Left != null && currentNode.Left.Value != lastPrint)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else if (currentNode.Right != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Right;
                }
                else
                {
                    PrintNode(currentNode);
                    lastPrint = currentNode.Value;
                    currentNode = null;
                }
            }
        }

        public void LevelOrderTraversal()
        {
            Queue queue = new Queue();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var currentNode = (TreeDSNode)queue.Dequeue();
                PrintNode(currentNode);
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
        }

        private void PrintNode(TreeDSNode node)
        {
            if (console != null)
                console.WriteLine(node.Value);
            else
                System.Console.Out.WriteLine(node.Value);
        }
    }
}
