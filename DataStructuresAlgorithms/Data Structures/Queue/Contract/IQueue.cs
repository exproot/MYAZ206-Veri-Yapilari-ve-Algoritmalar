namespace Queue;
public interface IQueue<T> {
    int Count {get;}
    void EnQueue(T item);
    T DeQueue();
    T Peek();
}