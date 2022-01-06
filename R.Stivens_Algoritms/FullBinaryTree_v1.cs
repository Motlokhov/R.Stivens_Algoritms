namespace R.Stivens_Algoritms
{
    internal class FullBinaryTree_v1
    {
        public BinaryNode Root { get; private set; }

        public void Add(long value)
        {
            if (Root == null)
            {
                Root = new BinaryNode(null, value);
                return;
            }

            AddNode(Root, value);
        }

        private void AddNode(BinaryNode root, long value)
        {
            AddToLayer(value, root);
        }

        private void AddToLayer(long value,params BinaryNode[] nodes)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Left == null)
                {
                    nodes[i].Left = new BinaryNode(nodes[i], value);
                    return;
                }
                else if(nodes[i].Right == null)
                {
                    nodes[i].Right = new BinaryNode(nodes[i], value);
                    return;
                }
            }

            BinaryNode[] children = new BinaryNode[nodes.Length * BinaryNode.Binary];
            for (int i = 0; i < nodes.Length; i++)
            {
                children[i * BinaryNode.Binary] = nodes[i].Left;
                children[i * BinaryNode.Binary + 1] = nodes[i].Right;
            }

            AddToLayer(value, children);
        }

        public class BinaryNode
        {
            public const byte Binary = 2;

            public BinaryNode(BinaryNode parent, long value)
            {
                Parent = parent;
                Value = value;
            }

            public BinaryNode Parent { get; internal set; }
            public BinaryNode Left { get; internal set; }
            public BinaryNode Right { get; internal set; }
            public long Value { get; init; }
        }
    }
}
