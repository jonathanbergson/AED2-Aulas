using System;

namespace AED2_ListaDuplamenteEncadeada
{
    class List
    {
        private Node sentinel;

        public List()
        {
            sentinel = new Node(-1, null, null);
            sentinel.Previous = sentinel;
            sentinel.Next = sentinel;
        }

        public void Show()
        {
            Node current = sentinel.Next;
            while (current.Next != current)
            {
                Console.WriteLine(current.Elem);
                current = current.Next;
            }
        }

        public void Prepend(int elem)
        {
            Node node = new Node(elem, sentinel, sentinel.Next);
            node.Next.Previous = node;
            sentinel.Next = node;
        }
    }
}
