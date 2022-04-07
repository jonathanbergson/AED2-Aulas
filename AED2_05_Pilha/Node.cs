namespace AED2_05_Pilha
{
    public class Node
    {
        public int Elem { get; }
        public Node Next { get; }

        public Node(int elem, Node next)
        {
            Elem = elem;
            Next = next;
        }
    }
}
