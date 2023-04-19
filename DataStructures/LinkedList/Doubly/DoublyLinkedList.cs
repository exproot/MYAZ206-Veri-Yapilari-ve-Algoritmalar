using System.Collections;

namespace LinkedList.Doubly;

public class DoublyLinkedList<T> : IEnumerable<T>{
    public DoublyNode<T> Head {get; set;}
    public DoublyNode<T> Tail {get; set;}

    private bool isHeadNull {get; set;}

    public DoublyLinkedList() {
        this.isHeadNull = true;
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}