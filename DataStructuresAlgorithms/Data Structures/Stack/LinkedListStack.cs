﻿using LinkedList.Singly;
using Stack.Contract;

namespace Stack;

public class LinkedListStack<T> : IStack<T>
{
    private SinglyLinkedList<T> _innerList;
    public int Count => _innerList.Count;

    public LinkedListStack() {
        _innerList = new SinglyLinkedList<T>();
    }

    public LinkedListStack(IEnumerable<T> collection) : this() 
    {
        foreach (var item in collection)
        {
            Push(item);
        }
    }

    public T Peek()
    {
        return _innerList.Head is null
            ? default(T)
            : _innerList.Head.Val;
    }

    public T Pop()
    {
        if(_innerList.Head is null)
            throw new Exception("Stack is empty !");
        return _innerList.RemoveFirst();
    }

    public void Push(T item)
    {
        _innerList.AddFirst(item);
    }
}
