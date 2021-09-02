using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.GenericTree.Model
{
    public class GenericTreeNode
    {
        public GenericTreeNode(int value)
        {
            this.Value = value;
        }
        public int Value;
        public GenericTreeNode Child;
        public GenericTreeNode Sibiling;
    }
}
