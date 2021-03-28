using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.MirrorImageOfTree
{
    public class MirrorImageOfTree
    {

        public MirrorImageOfTree()
        {

        }

        public TreeDSNode Create(TreeDSNode root)
        {
            if (root == null)
                return null;

            var tempLeft = root.Left;
            var tempRight = root.Right;

            root.Left = Create(root.Right);
            root.Right = Create(tempLeft);

            return root;
        }

        public bool Validate(TreeDSNode rootOfFirstTree, TreeDSNode rootOfSecondTree)
        {
            if (rootOfFirstTree == null && rootOfSecondTree == null)
                return true;

            if (rootOfFirstTree == null && rootOfSecondTree != null)
                return false;

            if (rootOfFirstTree != null && rootOfSecondTree == null)
                return false;

            return rootOfFirstTree.Value == rootOfSecondTree.Value && Validate(rootOfFirstTree.Left, rootOfSecondTree.Right) && Validate(rootOfFirstTree.Right, rootOfSecondTree.Left);
        }
    }
}
