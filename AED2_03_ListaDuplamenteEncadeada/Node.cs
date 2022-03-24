namespace AED2_03_ListaDuplamenteEncadeada
{
    class Node
    {
        int elem;
        Node previous;
        Node next;

        public int Elem
        {
            get => elem;
            set => elem = value;
        }

        public Node Next
        {
            get => next;
            set => next = value;
        }

        public Node Previous
        {
            get => previous;
            set => previous = value;
        }

        public Node(int elem, Node previous, Node next)
        {
            this.elem = elem;
            this.previous = previous;
            this.next = next;
        }
    }
}
