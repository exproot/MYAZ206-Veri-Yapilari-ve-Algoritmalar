using Queue;

namespace QueueTests;

public class ArrayQueueTests {
    [Fact]
    public void ArrayQueue_EnQueue_Test(){
        //arrange
        var queue = new ArrayQueue<char>();

        //act
        queue.EnQueue('e');
        queue.EnQueue('y');

        //assert
        Assert.Equal(2, queue.Count);
    }

    [Fact]
    public void ArrayQueue_DeQueue_Test(){
        //arrange
        var queue = new ArrayQueue<char>();

        //act
        queue.EnQueue('e');
        queue.EnQueue('y');
        var result = queue.DeQueue();

        //assert
        Assert.Equal(1, queue.Count);
        Assert.Equal('e', result);
    }

    [Fact]
    public void ArrayQueue_Peek_Test(){
        //arrange
        var queue = new ArrayQueue<char>();

        //act
        queue.EnQueue('e');
        queue.EnQueue('y');
        var result = queue.Peek();

        //assert
        Assert.Equal(2, queue.Count);
        Assert.Equal('e', result);
    }

    [Fact]
    public void ArrayQueue_IEnumerable_Constructor_Test(){
        //arrange n act
        var queue = new ArrayQueue<char>("Ertan".ToArray());

        //assert
        Assert.Equal(5, queue.Count);
        Assert.Equal('E', queue.Peek());
    }
}