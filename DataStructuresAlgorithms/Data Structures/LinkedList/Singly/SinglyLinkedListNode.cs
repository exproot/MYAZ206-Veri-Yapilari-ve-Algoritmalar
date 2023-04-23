namespace LinkedList.Singly;

public class SinglyLinkedListNode<T>
{
    public T? Val {get; set;}
    public SinglyLinkedListNode<T> Next { get; set; }

    public SinglyLinkedListNode() { }
    public SinglyLinkedListNode(T value)
    {
        Val = value;
    }

    public override string ToString() {
        return $"{Val}";
    }
}
