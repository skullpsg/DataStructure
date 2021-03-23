using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
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

        public void Travel() { 
         
        }
    }
}
