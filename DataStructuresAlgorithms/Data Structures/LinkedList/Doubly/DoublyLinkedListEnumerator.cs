using System.Collections;

namespace LinkedList.Doubly
{
    public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private DbNode<T> head;
        private DbNode<T> tail;
        public DbNode<T> Curr;

        public DoublyLinkedListEnumerator() {}
        public DoublyLinkedListEnumerator(DbNode<T> head, DbNode<T> tail)
        {
            this.head = head;
            this.tail = tail;
            Curr = null;
        }

        public T Current => Curr.Value ?? default(T);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            head = null;
            tail = null;
        }

        public bool MoveNext()
        {
            if(head == null)
                return false;
            
            if(Curr is null) {
                Curr = head;
                return true;
            }

            if(Curr.Next is not null) {
                Curr = Curr.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            head = null;
            tail = null;
            Curr = null;
        }
    }
}