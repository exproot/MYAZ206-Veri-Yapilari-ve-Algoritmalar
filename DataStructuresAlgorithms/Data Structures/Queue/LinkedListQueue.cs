using LinkedList.Doubly;

namespace Queue;

public class LinkedListQueue<T> : IQueue<T>
{
    private readonly DoublyLinkedList<T> _list;

    public LinkedListQueue() {
        _list = new DoublyLinkedList<T>();
    }

    public LinkedListQueue(IEnumerable<T> collection) : this() {
        foreach (var item in collection)
        {
            EnQueue(item);
        }
    }
    public int Count => _list.Count();

    public T DeQueue()
    {
        return _list.RemoveFirst();
    }

    public void EnQueue(T item)
    {
         _list.AddLast(item);
    }

    public T Peek()
    {
        return _list.Head.Value ?? default(T);
    }
}
