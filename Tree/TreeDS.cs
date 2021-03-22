using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree
{
    public class TreeDS
    {
        public TreeDSNode root = null;

        public TreeDS(int rootValue)
        {
            root = TreeDSNode.Create(rootValue);
        }

        public void AddLeft(int nodeValue, int leftOfValue)
        {
            throw new NotImplementedException();
        }

        public TreeDSNode GetNodeUsingRecursion(TreeDSNode root, int valueToFind)
        {

            if (root.Value == valueToFind)
                return root;

            if (root.Left != null)
                GetNodeUsingRecursion(root.Left, valueToFind);
            if (root.Left != null)
                GetNodeUsingRecursion(root.Right, valueToFind);

            return null;
        }
    }
}
