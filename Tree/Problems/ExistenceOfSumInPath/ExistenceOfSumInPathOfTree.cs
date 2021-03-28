using Datastructure.Common;
using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.ExistenceOfSumInPath
{
    public class ExistenceOfSumInPathOfTree
    {
        public bool UsingNonRecursion(TreeDSNode root)
        {
            throw new NotImplementedException();
        }

        public bool Check(TreeDSNode root, int sum)
        {
            if (root == null || root.Value > sum)
                return false;

            int remainingSum = sum - root.Value;

            if (remainingSum == 0)
                return true;

            return Check(root.Left, remainingSum) || Check(root.Right, remainingSum);
        }
    }
}
