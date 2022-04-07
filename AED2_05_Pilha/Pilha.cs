using System;

namespace AED2_05_Pilha
{
    internal class Pile
    {
        private Node _top;
        private int _count;

        public Pile()
        {
            _top = null;
            _count = 0;
        }

        public int Count => _count;

        public void Add(int elem)
        {
            Node node = new Node(elem, _top);
            _top = node;
            _count++;
        }

        public int Remove()
        {
            if(_top == null)
            {
                throw new Exception("Pilha vazia. Nenhum elemento para remover.");
            }

            var removed = _top.Elem;
            _top = _top.Next;
            _count--;

            return removed;
        }

        public void Show()
        {
            Console.WriteLine("\n\t[ ");
            for (Node node = _top; node != null; node = node.Next)
            {
                Console.WriteLine($"\t{node.Elem}");
            }
            Console.WriteLine("\t]");
        }
    }
}
