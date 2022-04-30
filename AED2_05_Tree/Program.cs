using System;

namespace AED2_05_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Add(16);
            tree.Add(8);
            tree.Add(4);
            tree.Add(15);
            tree.Add(23);
            tree.Add(72);
            tree.Add(42);

            tree.Show();
            tree.Remove(15);
            tree.Show();
            tree.Remove(42);
            tree.Show();
            tree.Remove(8);
            tree.Show();
            tree.Remove(23);
            tree.Show();
        }
    }
}
