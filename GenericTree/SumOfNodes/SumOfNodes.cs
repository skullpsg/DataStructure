using Datastructure.GenericTree.Model;

namespace Datastructure.GenericTree.SumOfNodes
{
    public class SumOfNodes
    {

        public int Find(GenericTreeNode node) {
            if (node == null)
                return 0;

            return node.Value + Find(node.Child) + Find(node.Sibiling);
        }

    }
}
