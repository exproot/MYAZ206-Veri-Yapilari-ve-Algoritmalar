using System.Collections;

namespace LinkedList.Singly
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        public SinglyLinkedListNode<T> Head {get; set;}
        public SinglyLinkedListNode<T> Curr {get; set;}

        public SinglyLinkedListEnumerator(){}

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T>? head)
        {
            Head = head;
            Curr = null;
        }

        public T Current => Curr.Val ?? default(T);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if(Head == null)
                return false;
            if(Curr == null){
                Curr = Head;
                return true;
            }
            if(Curr.Next != null) {
                Curr = Curr.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Curr = null;
            Head = null;
        }
    }
}