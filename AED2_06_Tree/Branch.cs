namespace AED2_06_Tree
{
    class Branch
    {
        public int Element { get; }
        public Branch Left { get; set; }
        public Branch Right { get; set; }

        public Branch(int element, Branch left, Branch right)
        {
            Element = element;
            Left = left;
            Right = right;
        }
    }
}
