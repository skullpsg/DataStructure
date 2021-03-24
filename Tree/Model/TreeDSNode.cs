using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Model
{
    public class TreeDSNode
    {
        public int Value;
        public TreeDSNode Left;
        public TreeDSNode Right;
        public TreeDSNode(int value, TreeDSNode left, TreeDSNode right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        public bool isLeftNodeNull()
        {
            return this.Left == null;
        }

        public bool isRightNodeNull()
        {
            return this.Right == null;
        }

        public bool isLeftNodeAvailable()
        {
            return this.Left != null;
        }

        public bool isRightNodeAvailable()
        {
            return this.Right != null;
        }

        public static TreeDSNode Create(int value)
        {
            return new TreeDSNode(value, null, null);
        }
    }
}
