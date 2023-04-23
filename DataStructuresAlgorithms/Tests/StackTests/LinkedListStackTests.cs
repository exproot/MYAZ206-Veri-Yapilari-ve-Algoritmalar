using Stack;

namespace StackTests;

public class LinkedListStackTests
{
    [Fact]
    public void LinkedListStack_Push_Test()
    {
        //arrange
        var stack = new LinkedListStack<int>();

        //act
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        //assert
        Assert.Equal(3, stack.Count);
    }
    
    [Fact]
    public void LinkedListStack_Pop_Test()
    {
        //arrange
        var stack = new LinkedListStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        //act
        var result = stack.Pop();

        //assert
        Assert.Equal(2, stack.Count);
        Assert.Equal(3, result);
    }

    [Fact]
    public void LinkedListStack_Peek_Test()
    {
        //arrange
        var stack = new LinkedListStack<string>();
        stack.Push("Ertan");
        stack.Push("Yagmur");
        stack.Push("jk");

        //act
        var result = stack.Peek();

        //assert
        Assert.Equal(3, stack.Count);
        Assert.Equal("jk", result);
    }

    [Fact]
    public void LinkedListStack_Constructor_IEnumerable_Test()
    {
        // Arrange & Act
        var stack = new LinkedListStack<int>(new List<int>() { 10, 20, 30 });

        // Assert
        Assert.Equal(stack.Count, 3);
        Assert.Equal(stack.Peek(), 30);
    }
}