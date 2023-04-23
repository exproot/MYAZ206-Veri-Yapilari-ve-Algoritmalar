using LinkedList.Singly;

namespace SinglyLinkedListTests;

public class SinglyLinkedListNodeTests {

    [Fact]
    public void SinglyLinkedListNode_Test(){
        //arrange
        var testNode = new SinglyLinkedListNode<int>() { Val = 29};

        var testNode2 = new SinglyLinkedListNode<int>() { Val = 55};

        //act
        testNode.Next = testNode2;

        //assert
        Assert.Equal(testNode.Next, testNode2);
        Assert.Equal(testNode.Val, 29);
        Assert.Equal(testNode.Next.Val, 55);
        Assert.True(testNode.Next.Val == testNode2.Val);
    }
}