using System.Collections;

namespace LinkedList.Singly;

public class SinglyLinkedList<T> : IEnumerable<T> {

    public SinglyLinkedListNode<T>? Head { get; set; }

    public SinglyLinkedList()
    {
    }

    public SinglyLinkedList(IEnumerable<T> collection) {
        foreach (var item in collection)
        {
            AddFirst(item);
        }
    }

    /// <summary>
    /// Bağlı listenin başına eleman ekler
    /// </summary>
    /// <param name="item"></param>
    public void AddFirst(T item) {

        var node = new SinglyLinkedListNode<T>() {Val = item};

        if(Head == null) {
            Head = node;
            return;
        }

        node.Next = Head;
        Head = node;
        return;

    }

    /// <summary>
    /// Bağlı listenin sonuna eleman ekler. 
    /// </summary>
    /// <param name="item"></param>
    public void AddLast(T item){

        var node = new SinglyLinkedListNode<T>() { Val = item};

        if(Head is null) {
            Head = node;
            return;
        }

        var current = Head;
        var prev = current;

        while(current != null){
            prev = current;
            current = current.Next;
        }
        prev.Next = node;
        return;
    }

    public void AddBefore(SinglyLinkedListNode<T> givenNode, T item) {

        if(Head is null) {
            AddFirst(item);
            return;
        }

        var node = new SinglyLinkedListNode<T>(item);

        var current = Head;
        var prev = current;

        while(current != null){

            if(current.Equals(givenNode)){
                node.Next = current;
                prev.Next = node;
                return;
            }

            prev = current;
            current = current.Next;
        }
        throw new Exception("node not found!");
    }

    /// <summary>
    /// Week 4 - Verilen düğümden sonraya verilen T değerini ekler.
    /// </summary>
    /// <param name="node"></param>
    /// <param name="item"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void AddAfter(SinglyLinkedListNode<T> node, T item)
    {
        if(Head == null) {
            AddFirst(item);
            return;
        }

        var newNode = new SinglyLinkedListNode<T>(item);

        var current = Head;

        while(current != null) {

            if(current.Equals(node)){
                newNode.Next = current.Next;
                current.Next = newNode;
                return;
            }

            current = current.Next;
        }
        throw new Exception("node not found!");
    }

    /// <summary>
    /// Week 4 - Bağlı listenin başındaki düğümü çıkarır.
    /// Çıkarılan düğümün değerini geri döndürür.
    /// </summary>
    /// <returns></returns>
    public T RemoveFirst() {
        
        if(Head is null) {
            throw new Exception("list is empty!");
        }

        T item = Head.Val;
        Head = Head.Next;
        return item;
    }

    /// <summary>
    /// Week 4 - Bağlı listenin sonundaki düğümü çıkarır.
    /// Çıkarılan düğümün değerini geri döndürür.
    /// </summary>
    /// <returns></returns>
    public T RemoveLast() {
        
        if(Head is null) {
            throw new Exception("list is empty!");
        }

        var current = Head;
        var prev = current;

        if(current.Next is null) {
            T item = current.Val;
            Head = null;
            return item;
        }


        while(current != null) {

            
            if(current.Next is null){
                
                T item = current.Val;
                prev.Next = null;
                return item;
            }

            prev = current;
            current = current.Next;
            
        }

        throw new Exception();
    }

    /// <summary>
    /// Week 4 - Bağlı listeden verilen düğümü çıkarır.
    /// Eğer düğüm bağlı listede bulunmuyorsa hata fırlatır.
    /// Çıkarılan değeri geri döndürür.
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public T Remove(SinglyLinkedListNode<T> node) {

        if(Head is null) {
            throw new Exception("List is empty!");
        }

        if(Head.Val.Equals(node.Val)) {
            return RemoveFirst();
        }

        var current = Head;
        var prev = current;

        while(current != null){

            if(prev.Next.Val.Equals(node.Val)){
                T item = node.Val;
                prev.Next = current.Next;
                current = null;
                return item;
            }

            prev = current;
            current = current.Next;
        }
        throw new Exception("Given node not found!");
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(Head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}