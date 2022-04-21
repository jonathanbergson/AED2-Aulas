namespace AED2_05_Tree
{
    class Tree
    {
        Node _root;

        public Tree()
        {

        }

        public bool Find(int element)
        {
            return Find(element, _root);
        }

        private bool Find(int element, Node branch)
        {
            bool found = false;

            if (element == branch.Element)
            {
                found = true;
            }
            else if (element < branch.Element)
            {
                found = Find(element, branch.Left);
            }
            else if (element > branch.Element)
            {
                found = Find(element, branch.Right);
            }

            return found;
        }

        public void Show()
        {

        }
    }
}
