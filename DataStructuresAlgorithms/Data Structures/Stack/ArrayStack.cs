using Array;
using Stack.Contract;

namespace Stack;

public class ArrayStack<T> : IStack<T>
{
    private Array<T> _innerArray;
    private int LastIndex => Count - 1;

    public ArrayStack() {
        _innerArray = new Array<T>();
    }

    public ArrayStack(IEnumerable<T> collection) : this() 
    {
        foreach (var item in collection)
        {
            Push(item);
        }
    }
    public int Count => _innerArray.Count;

    public T Peek()
    {
        if(Count == 0){
            return default(T);
        }
        return _innerArray.GetItem(LastIndex);
    }

    public T Pop()
    {
        if(Count == 0){
            throw new Exception("Stack is empty!");
        }
        var temp = _innerArray.Remove();
        return temp;
    }

    public void Push(T item)
    {
        _innerArray.Add(item);
    }
}