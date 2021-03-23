using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Test
{
    public class TreeTestData
    {

        public static TreeDSNode GetSimpleTreeRootNode()
        {
            TreeDSNode nodeWithValue4, nodeWithValue6, root;
            nodeWithValue4 = TreeDSNode.Create(4);
            var nodeWithValue5 = TreeDSNode.Create(5);
            nodeWithValue6 = TreeDSNode.Create(6);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue4, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, nodeWithValue6, null);
            root = new TreeDSNode(1, nodeWithValue2, nodeWithValue3);
            return root;
        }
    }
}
