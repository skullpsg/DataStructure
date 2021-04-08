using Datastructure.Tree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Tree.Problems.Test.Data
{
    public class TreeTestData
    {

        // Tree structure
        //       1
        //    2    3
        //   4 5  6

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

        // Tree structure
        //        1
        //    2       3
        //  4   5   6
        //     7 8
        // inOrder : 4, 2, 7, 5, 8, 1, 6, 3
        // preOrder : 1, 2, 4, 5, 7, 8, 3, 6
        public static TreeDSNode GetComplexTreeRootNode()
        {
            TreeDSNode nodeWithValue4, nodeWithValue7, nodeWithValue8, root;
            nodeWithValue4 = TreeDSNode.Create(4);
            nodeWithValue7 = TreeDSNode.Create(7);
            nodeWithValue8 = TreeDSNode.Create(8);
            var nodeWithValue6 = TreeDSNode.Create(6);
            var nodeWithValue5 = new TreeDSNode(5, nodeWithValue7, nodeWithValue8);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue4, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, nodeWithValue6, null);
            root = new TreeDSNode(1, nodeWithValue2, nodeWithValue3);
            return root;
        }

        // Tree structure
        //        70
        //    80       47
        //  90   108   99
        //     54 77
        public static TreeDSNode GetRootNodeOfComplexTreeWithHighervalue()
        {
            TreeDSNode nodeWithValue4, nodeWithValue7, nodeWithValue8, nodeWithValue6, root;
            nodeWithValue4 = TreeDSNode.Create(90);
            nodeWithValue7 = TreeDSNode.Create(54);
            nodeWithValue8 = TreeDSNode.Create(77);
            var nodeWithValue5 = TreeDSNode.Create(108);
            nodeWithValue6 = new TreeDSNode(99, nodeWithValue7, nodeWithValue8);
            TreeDSNode nodeWithValue2 = new TreeDSNode(80, nodeWithValue4, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(47, nodeWithValue6, null);
            root = new TreeDSNode(70, nodeWithValue2, nodeWithValue3);
            return root;
        }

        // Tree structure
        //        1
        //     3      2
        //      6   5    4
        //              8  7
        public static TreeDSNode GetRootNodeOfComplexTreeMirror()
        {
            TreeDSNode nodeWithValue4, nodeWithValue7, nodeWithValue8, root;
            nodeWithValue4 = TreeDSNode.Create(4);
            nodeWithValue7 = TreeDSNode.Create(7);
            nodeWithValue8 = TreeDSNode.Create(8);
            var nodeWithValue6 = TreeDSNode.Create(6);
            var nodeWithValue5 = new TreeDSNode(5, nodeWithValue8, nodeWithValue7);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue5, nodeWithValue4);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, null, nodeWithValue6);
            root = new TreeDSNode(1, nodeWithValue3, nodeWithValue2);
            return root;
        }


        // Tree structure
        //        1
        //    2       3
        //  4    5       10
        // 6 7  8  9         11
        //                 12
        public static TreeDSNode GetComplexTreeRootNodeWith12Nodes()
        {
            TreeDSNode nodeWithValue4, nodeWithValue11, nodeWithValue10, root;
            TreeDSNode nodeWithValue7 = TreeDSNode.Create(7);
            TreeDSNode nodeWithValue8 = TreeDSNode.Create(8);
            TreeDSNode nodeWithValue9 = TreeDSNode.Create(9);
            TreeDSNode nodeWithValue12 = TreeDSNode.Create(12);

            nodeWithValue11 = new TreeDSNode(11, nodeWithValue12, null);
            nodeWithValue10 = new TreeDSNode(10, null, nodeWithValue11);
            var nodeWithValue6 = TreeDSNode.Create(6);
            nodeWithValue4 = new TreeDSNode(4, nodeWithValue6, nodeWithValue7);
            var nodeWithValue5 = new TreeDSNode(5, nodeWithValue8, nodeWithValue9);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue4, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, null, nodeWithValue10);
            root = new TreeDSNode(1, nodeWithValue2, nodeWithValue3);
            return root;
        }



        // Tree structure (left splay tree)
        //        1
        //       2       
        //      3       
        //     4       
        //    5       
        //   6       

        public static TreeDSNode GetLeftSplayTreeRootNode()
        {
            TreeDSNode nodeWithValue6, root;
            nodeWithValue6 = TreeDSNode.Create(6);
            TreeDSNode nodeWithValue5 = new TreeDSNode(5, nodeWithValue6, null);
            TreeDSNode nodeWithValue4 = new TreeDSNode(4, nodeWithValue5, null);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, nodeWithValue4, null);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, nodeWithValue3, null);
            root = new TreeDSNode(1, nodeWithValue2, null);
            return root;
        }



        // Tree structure (right splay tree)
        //        1
        //         2       
        //          3       
        //           4       
        //            5       
        //             6       

        public static TreeDSNode GetRightSplayTreeRootNode()
        {
            TreeDSNode nodeWithValue6, root;
            nodeWithValue6 = TreeDSNode.Create(6);
            TreeDSNode nodeWithValue5 = new TreeDSNode(5, null, nodeWithValue6);
            TreeDSNode nodeWithValue4 = new TreeDSNode(4, null, nodeWithValue5);
            TreeDSNode nodeWithValue3 = new TreeDSNode(3, null, nodeWithValue4);
            TreeDSNode nodeWithValue2 = new TreeDSNode(2, null, nodeWithValue3);
            root = new TreeDSNode(1, nodeWithValue2, null);
            return root;
        }
    }
}
