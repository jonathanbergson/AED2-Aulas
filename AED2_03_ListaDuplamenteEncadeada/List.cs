using System;

namespace AED2_03_ListaDuplamenteEncadeada
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

        public void Add(int elem, int position = 1)
        {
            bool shouldPush = false;

            if (position == 0)
            {
                Prepend(elem);
            }

            int index = 1;
            Node current = sentinel.Next;
            while(index < position)
            {
                index++;
                current = current.Next;

                if (current == sentinel)
                {
                    shouldPush = true;
                    break;
                }
            }

            if (shouldPush)
            {
                Push(elem);
            } else
            {
                Node node = new Node(elem, current.Previous, current);
                current.Previous.Next = node;
                current.Previous = node;
            }
        }

        public int Shift()
        {
            Node firstNode = sentinel.Next;

            if (firstNode == sentinel)
            {
                throw new Exception("[Exception] A lista está vazia!");
            }

            sentinel.Next = firstNode.Next;
            firstNode.Next.Previous = sentinel;

            return firstNode.Elem;
        }

        public int Pop()
        {
            Node lastNode = sentinel.Previous;

            if (lastNode == sentinel)
            {
                throw new Exception("[Exception] A lista está vazia!");
            }

            sentinel.Previous = lastNode.Previous;
            sentinel.Previous.Next = sentinel;

            return lastNode.Elem;
        }
    }
}
