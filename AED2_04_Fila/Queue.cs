using System;

namespace AED2_04_Fila
{
    class Queue
    {
        private int _count;
        private Node _head;
        private Node _tail;
        
        public Queue()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }
        
        public int Count
        {
            get => _count;
        }

        public void Toqueue(string name)
        {
            Node newNode = new Node(name);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
                _count++;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
                _count++;
            }
        }

        public void Dequeue()
        {
            if (_head != null)
            {
                _head = _head.Next;
                _count--;
            }
            
            if (_count == 0)
            {
                _tail = null;
            }
        }

        public void Look(int count = 1)
        {
            if (count == -1 || count > _count)
            {
                count = _count;
            }

            Node current = _head;
            
            Console.Write("\t[ ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{current.Name} -> ");
                current = current.Next;
            }
            Console.Write("]\n");
        }

        public void Show()
        {
            Look(-1);
        }
    }
}
