using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.LeastCommonAncestor
{
    public class LeastCommonAncestor
    {
        public TreeDSNode Find(TreeDSNode root, TreeDSNode alpha, TreeDSNode beta)
        {
            if (root == null)
                return null;

            if (root.Value == alpha.Value || root.Value == beta.Value)
                return root;

            var leftLCA = Find(root.Left, alpha, beta);
            var rightLCA = Find(root.Right, alpha, beta);

            if (leftLCA != null && rightLCA != null)
                return root;

            return leftLCA != null ? leftLCA : rightLCA;
        }
    }
}
