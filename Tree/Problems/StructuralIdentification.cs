using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems
{
    public class StructuralIdentification
    {
        public bool Validate(TreeDSNode rootOfFirstTree, TreeDSNode rootOfSecondTree)
        {
            if (rootOfFirstTree == null && rootOfSecondTree == null)
                return true;

            if (rootOfFirstTree != null && rootOfSecondTree == null)
                return false;
            else if (rootOfFirstTree == null && rootOfSecondTree != null)
                return false;

            return Validate(rootOfFirstTree.Left, rootOfSecondTree.Left) && Validate(rootOfFirstTree.Right, rootOfSecondTree.Right);
        }
    }
}
