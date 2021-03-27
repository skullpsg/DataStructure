using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;

namespace Datastructure.Tree.Problems.PrintingTreeNodesFromRootToLeaf
{
    public class PrintingTreeNodesFromRootToLeaf
    {
        public IConsoleWriter console = null;
        public PrintingTreeNodesFromRootToLeaf(IConsoleWriter console = null)
        {
            this.console = console;
        }

        public void Print(TreeDSNode root, List<int> path)
        {
            if (root == null)
                return;
            path.Add(root.Value);
            if (root.isLeftNodeNull() && root.isRightNodeNull())
            {
                String pathStr = string.Join(",", path);
                console.WriteLine("Tree path: " + pathStr);
            }
            else
            {
                if (root.isLeftNodeAvailable())
                    Print(root.Left, new List<int>(path));
                if (root.isRightNodeAvailable())
                    Print(root.Right, new List<int>(path));
            }
        }
    }
}
