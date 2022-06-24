using System;

namespace AED2_05_Tree
{
    class Tree
    {
        Branch _root;

        public void Add(int element)
        {
            _root = Add(element, _root);
        }

        private Branch Add(int element, Branch branch)
        {
            if (branch == null) 
            {
                branch = new Branch(element, null, null);
                return branch;
            }
            else if (element < branch.Element)
            {
                branch.Left = Add(element, branch.Left);
                return branch;
            }
            else if (element > branch.Element)
            {
                branch.Right = Add(element, branch.Right) ;
                return branch;
            }
            else
            {
                throw new Exception("[Exception] O elemento já existe na árvore!");
            }
        }

        public bool Find(int element)
        {
            return Find(element, _root);
        }

        private bool Find(int element, Branch branch)
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
            Console.Write("\n\t[ ");
            Show(_root);
            Console.Write("]");
        }

        private void Show(Branch branch)
        {
            if (branch != null)
            {
                Show(branch.Left);
                Console.Write($"{branch.Element}, ");
                Show(branch.Right);
            }
        }

        public void ShowOrdened()
        {
            Console.Write("\n\t[ ");
            ShowOrdened(_root);
            Console.Write("]");
        }

        private void ShowOrdened(Branch branch)
        {
            if (branch != null)
            {
                Console.Write($"{branch.Element}, ");
                ShowOrdened(branch.Left);
                ShowOrdened(branch.Right);
            }
        }

        public void Remove(int element)
        {
            _root = Remove(element, _root);
        }

        private Branch Remove(int element, Branch branch)
        {
            if (element == branch.Element)
            {
                if (branch.Right == null)
                {
                    branch = branch.Left;
                }
                else if (branch.Left == null)
                {
                    branch = branch.Right;
                }
                return branch;
            }
            else if (element < branch.Element)
            {
                branch.Left = Remove(element, branch.Left);
                return branch;
            }
            else if (element > branch.Element)
            {
                branch.Right = Remove(element, branch.Right);
                return branch;
            }
            else
            {
                throw new Exception("[Exception] Algum erro...");
            }
        }
    }
}
