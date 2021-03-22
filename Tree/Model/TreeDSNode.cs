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

        public static TreeDSNode Create(int value)
        {
            return new TreeDSNode(value, null, null);
        }
    }
}
