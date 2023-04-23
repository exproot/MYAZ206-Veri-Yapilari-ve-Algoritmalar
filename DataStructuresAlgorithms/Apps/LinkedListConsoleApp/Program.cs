using LinkedList.Singly;

namespace LinkedListConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        
        
    }

    private static void llRemove()
    {
        var llist1 = new SinglyLinkedList<char>();

        llist1.AddFirst('e');    //e
        llist1.AddFirst('d');    //d-e
        llist1.AddFirst('c');    //c-d-e
        llist1.AddFirst('b');    //b-c-d-e
        llist1.AddFirst('a');    //a-b-c-d-e

        var nodeToRemove = new SinglyLinkedListNode<char>('c');


        System.Console.WriteLine(llist1.Remove(nodeToRemove));
    }

    private static void llRemoveLast()
    {
        var llist1 = new SinglyLinkedList<char>();

        llist1.AddFirst('e');    //e
        llist1.AddFirst('d');    //d-e
        llist1.AddFirst('c');    //c-d-e
        llist1.AddFirst('b');    //b-c-d-e
        llist1.AddFirst('a');    //a-b-c-d-e

        var last = llist1.RemoveLast();

        System.Console.WriteLine(llist1.Head.Next.Next.Next.Next is null);
        System.Console.WriteLine(last);
    }

    private static void llAddBefore()
    {
        var llist1 = new SinglyLinkedList<char>();

        llist1.AddFirst('d');    //d
        llist1.AddFirst('c');    //c-d
        llist1.AddFirst('b');    //b-c-d
        llist1.AddFirst('a');    //a-b-c-d


        llist1.AddBefore(llist1.Head.Next.Next, 'x'); // a-b-x-c-d

        System.Console.WriteLine(llist1.Head.Next.Next);
    }
}
