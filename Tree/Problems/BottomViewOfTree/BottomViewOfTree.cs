using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.BottomViewOfTree
{
    class BottomViewOfTree
    {
        public Dictionary<int, TreeDSNode> dictionary = new Dictionary<int, TreeDSNode>();
        public IConsoleWriter console = null;

        public BottomViewOfTree(IConsoleWriter console)
        {
            this.console = console;
        }

        internal void view(TreeDSNode root, int verticalPosition)
        {

            if (root == null)
                return;

            dictionary[verticalPosition] = root;

            if (root.isLeftNodeAvailable())
            {
                view(root.Left, verticalPosition - 1);
            }

            if (root.isRightNodeAvailable())
            {
                view(root.Left, verticalPosition + 1);
            }

            Print(dictionary);
        }

        private void Print(Dictionary<int, TreeDSNode> dictionary)
        {
            foreach (var node in dictionary)
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
