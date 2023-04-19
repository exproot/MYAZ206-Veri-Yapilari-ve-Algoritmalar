using LinkedList.Doubly;

namespace DoublyLinkedListTests;

public class DoublyNodeTests
{
    [Fact]
    public void DbNode_Test()
    {
        //arrange
        var node = new DoublyNode<int>();

        //act
        node.Val = 1;
        node.Next = new DoublyNode<int>{Val = 3};
        node.Next.Prev = node;
        node.Next.Next = new DoublyNode<int>{Val = 5};
        node.Next.Next.Prev = node.Next;

        //assert
        Assert.Equal(1, node.Val);
        Assert.Equal(3, node.Next.Val);
        Assert.Equal(1, node.Next.Prev.Val);
        Assert.Equal(5, node.Next.Next.Val);
        Assert.Equal(3, node.Next.Next.Prev.Val);

    }
}