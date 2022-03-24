using System;

namespace AED2_ListaDinamica
{
    public class List
    {
        private Node head;
        private Node tail;

        public List()
        {
            head = new Node(-1, null);
            tail = head;
        }

        public void AddInit(int elem)
        {
            Node node = new Node(elem, head.next);
            head.next = node;

            if (node.next == null)
            {
                tail = node;
            }
        }

        public void Add(int elem)
        {
            Node node = new Node(elem, null);
            tail.next = node;
            tail = node;
        }

        public int Remove()
        {
            Node firstNode = head.next;

            if (firstNode == null)
            {
                throw new Exception("[Exception] Não existe elemento para ser removido.");
            }

            int elemDeteled = firstNode.elem;
            head.next = firstNode.next;

            if (head.next == null)
            {
                tail = head;
            }

            return elemDeteled;
        }

        public int RemoveTail()
        {
            if (head == tail)
            {
                throw new Exception("[Exception] Não existe elemento para ser removido.");
            }

            int elem = tail.elem;

            Node node = head;
            while (node.next != tail)
            {
                node = node.next;
            }

            tail = node;
            tail.next = null;

            return elem;
        }

        public bool Search(int elem)
        {
            Node node = head.next;
            bool hasElem = false;

            while (node != null)
            {
                if (node.elem == elem)
                {
                    hasElem = true;
                    break;
                }

                node = node.next;
            }

            return hasElem;
        }

        public void Show()
        {
            Node node = head.next;

            Console.Write("\n[ ");
            while (node != null)
            {
                Console.Write($"{node.elem}, ");
                node = node.next;
            }
            Console.Write("]\n");
        }
    }
}
