using Queue;

namespace QueueTests;

public class LinkedListQueueTests
{
    [Theory]
    [InlineData(5)]
    [InlineData(15)]
    public void LinkedListQueue_EnQueue_Test(int item)
    {
        //arrange
        var queue = new LinkedListQueue<int>();

        //act
        queue.EnQueue(10);
        queue.EnQueue(item);

        //assert
        Assert.Equal(2,queue.Count);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(15)]
    public void LinkedListQueue_DeQueue_Test(int item)
    {
        //arrange
        var queue = new LinkedListQueue<int>();

        //act
        queue.EnQueue(10);
        queue.EnQueue(item);
        var result = queue.DeQueue();

        //assert
        Assert.Equal(1,queue.Count);
        Assert.Equal(10, result);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(15)]
    public void LinkedListQueue_Peek_Test(int item)
    {
        //arrange
        var queue = new LinkedListQueue<int>();

        //act
        queue.EnQueue(10);
        queue.EnQueue(item);
        var result = queue.Peek();

        //assert
        Assert.Equal(2,queue.Count);
        Assert.Equal(10, result);
    }

    [Fact]
    public void LinkedListQueue_IEnumerable_Constructor_Test(){
        //arrange n act
        var queue = new LinkedListQueue<char>("Ertan".ToArray());

        //assert
        Assert.Equal(5, queue.Count);
        Assert.Equal('E', queue.Peek());

    }
}