namespace Queue;

public class ArrayQueue<T> : IQueue<T>
{
    //private readonly List<T> _innerList;
    private readonly Array.Array<T> _innerArray;

    public ArrayQueue() {
        //_innerList = new List<T>();
        _innerArray = new Array.Array<T>();
    }

    public ArrayQueue(IEnumerable<T> collection) : this() {
        foreach (var item in collection)
        {
            EnQueue(item);
        }
    }
    //public int Count => _innerList.Count();
    public int Count => _innerArray.Count;

    public T DeQueue()
    {
        if(Count.Equals(0))
            throw new Exception("The queue is empty !");
        //var item = _innerList[0];
        //_innerList.RemoveAt(0);
        //return item;
        return _innerArray.RemoveItem(0);
    }

    public void EnQueue(T item)
    {
        _innerArray.Add(item);
    }

    public T Peek()
    {
        //return Count == 0 ? default : _innerList[0];
        return Count == 0 ? default : _innerArray.GetItem(0);
    }   
}