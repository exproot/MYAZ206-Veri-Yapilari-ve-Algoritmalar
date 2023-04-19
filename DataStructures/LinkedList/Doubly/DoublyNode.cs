namespace LinkedList.Doubly;

public class DoublyNode<T> {
    public T? Val {get; set;}

    public DoublyNode<T> Next {get; set;}
    public DoublyNode<T> Prev {get; set;}

    public DoublyNode()
    {
        Next = null;
        Prev = null;
    }
    public DoublyNode(T? v)
    {
        Val = v;
        Next = null;
        Prev = null;
    }

    public override string? ToString() {
        return $"{Val}";
    }
}