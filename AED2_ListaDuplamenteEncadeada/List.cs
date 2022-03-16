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
            Console.Write("\n\t[ ");
            for (Node node = sentinel.Next; node != sentinel; node = node.Next)
            {
                Console.Write($"{node.Elem} ");
            }
            Console.Write("]\n");
        }

        public void Prepend(int elem)
        {
            Node node = new Node(elem, sentinel, sentinel.Next);
            node.Previous.Next = node;
            node.Next.Previous = node;
            //node.Next.Previous = node;
            //sentinel.Next = node;
        }

        public void Push(int elem)
        {
            Node node = new Node(elem, sentinel.Previous, sentinel);
            sentinel.Previous.Next = node;
            sentinel.Previous = node;
        }

        public void Shift()
        {

        }

        public void Pop()
        {

        }
    }
}
