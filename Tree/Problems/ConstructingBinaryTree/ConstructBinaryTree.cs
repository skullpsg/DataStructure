using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.ConstructingBinaryTree
{
    public class ConstructBinaryTree
    {
        public static int preIndex = 0;

        public TreeDSNode FromInorderAndPreOrder(List<int> inOrder, List<int> preOrder, int startIndex, int endIndex)
        {

            if (startIndex > endIndex)
            {
                return null;
            }

            TreeDSNode root = TreeDSNode.Create(preOrder[preIndex]);
            preIndex++;

            if (startIndex == endIndex)
            {
                return root;
            }

            int indexOfFirstNodeInInorder = inOrder.IndexOf(root.Value);

            root.Left = FromInorderAndPreOrder(inOrder, preOrder, startIndex, indexOfFirstNodeInInorder - 1);
            root.Right = FromInorderAndPreOrder(inOrder, preOrder, indexOfFirstNodeInInorder + 1, endIndex);

            return root;
        }

    }
}
