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
        public static int postIndex = 7;

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

        public TreeDSNode FromInorderAndPostOrder(List<int> inOrder, List<int> postOrder, int startIndex, int endIndex)
        {

            if (startIndex > endIndex)
            {
                return null;
            }

            TreeDSNode root = TreeDSNode.Create(postOrder[postIndex]);
            postIndex--;

            if (startIndex == endIndex)
            {
                return root;
            }

            int indexOfFirstNodeInInorder = inOrder.IndexOf(root.Value);

            root.Right = FromInorderAndPostOrder(inOrder, postOrder, indexOfFirstNodeInInorder + 1, endIndex);
            root.Left = FromInorderAndPostOrder(inOrder, postOrder, startIndex, indexOfFirstNodeInInorder - 1);

            return root;
        }

        public TreeDSNode FromInorderAndLevelOrder(List<int> inOrder, List<int> levelOrder, int startIndex, int endIndex)
        {
            int levelIndex = int.MaxValue;

            if (startIndex > endIndex)
            {
                return null;
            }
            // finding which element from level order appears in inorder
            for (int levelOrderIndex = 0; levelOrderIndex < levelOrder.Count; levelOrderIndex++)
            {

                int currentValue = levelOrder[levelOrderIndex];
                int inOrderIndex = inOrder.IndexOf(currentValue);

                if (startIndex <= inOrderIndex && inOrderIndex <= endIndex && inOrderIndex != -1)
                {
                    levelIndex = inOrderIndex;
                    break;
                }
            }


            TreeDSNode root = TreeDSNode.Create(inOrder[levelIndex]);

            if (startIndex == endIndex)
            {
                return root;
            }

            int indexOfFirstNodeInInorder = inOrder.IndexOf(root.Value);

            root.Left = FromInorderAndLevelOrder(inOrder, levelOrder, startIndex, levelIndex - 1);
            root.Right = FromInorderAndLevelOrder(inOrder, levelOrder, levelIndex + 1, endIndex);

            return root;
        }

    }
}
