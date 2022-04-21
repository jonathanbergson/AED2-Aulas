namespace AED2_05_Tree
{
    class Node
    {
        public int Element { get; }
        public Node Left { get; }
        public Node Right { get; }

        public Node(int element, Node left, Node right)
        {
            Element = element;
            Left = left;
            Right = right;
        }
    }
}
