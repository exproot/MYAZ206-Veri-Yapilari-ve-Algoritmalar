using System.Collections;

namespace LinkedList.Doubly;

public class DoublyLinkedList<T> : IEnumerable<T>{
    public DoublyNode<T> Head {get; set;}
    public DoublyNode<T> Tail {get; set;}

    private bool isHeadNull {get; set;}

    public DoublyLinkedList() {
        isHeadNull = true;
    }

    public DoublyLinkedList(IEnumerable<T> collection){
        isHeadNull = true;
        foreach (var item in collection)
        {
           AddLast(item); 
        }
    }

    public void AddFirst(T item)
    {
        var node = new DoublyNode<T>(item);
        if(isHeadNull)
        {
            Head = node;
            Tail = node;
            isHeadNull = false;
            return;
        }
        Head.Prev = node;
        node.Next = Head;
        Head = node;
    }

    public void AddLast(T item)
    {
        var node = new DoublyNode<T>(item);
        if (isHeadNull)
        {
            Head = node;
            Tail = node;
            isHeadNull = false;
            return;
        }
        Tail.Next = node;
        node.Prev = Tail;
        Tail = node;
    }

    public T RemoveFirst()
    {
        if (isHeadNull)
            throw new Exception("The linked list is empty!");

        T item = default;

        if (Head.Equals(Tail))
        {
            item = Head.Val;
            Head = null;
            Tail = null;
            return item;
        }

        item = Head.Val;
        Head = Head.Next;
        Head.Prev = null;
        return item;
    }

    public T RemoveLast()
    {

        if (isHeadNull)
            throw new Exception("The linked list is empty!");
        T item  = default;
        if (Head.Equals(Tail))
        {
            item = Head.Val;
            Head = null;
            Tail = null;
            return item;
        }
        item = Tail.Val;
        Tail = Tail.Prev;
        Tail.Next = null;
        return item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new DoublyLinkedListEnumerator<T>(Head, Tail);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}