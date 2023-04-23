using Stack;

namespace StackTests;

public class ArrayStackTests
{
    [Fact]
    public void ArrayStack_Push_Test() {
        //arrange
        var stack = new ArrayStack<int>();

        //act
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        //assert
        Assert.Equal(3, stack.Count);
    }

    [Fact]
    public void ArrayStack_Pop_Test() {
        //arrange
        var stack = new ArrayStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        //act
        var result = stack.Pop();

        //assert
        Assert.Equal(2, stack.Count);
        Assert.Equal(30, result);
    }

    [Fact]
    public void ArrayStack_Peek_Test() {
        //arrange
        var stack = new ArrayStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        //act
        var result = stack.Peek();

        //assert
        Assert.Equal(3, stack.Count);
        Assert.Equal(30, result);
    }

    [Fact]
    public void ArrayStack_Constructor_IEnumerable_Test() {
        //arrange
        var stack = new ArrayStack<int>(new List<int>() {10,20,30});

        //assert
        Assert.Equal(3, stack.Count);
        Assert.Equal(30, stack.Peek());
    }
}