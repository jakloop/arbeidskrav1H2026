using arbeidskrav1H2026.searchalgorithms;

namespace arbveidskrav1H2026.Tests;

public class UnitTest2
{
    [Fact]
    public void CustomStack_PeekShowsLatestPushedValue()
    {
        //arrange 
        CustomStack<int> stack = new CustomStack<int>();
        stack.Push(10);
        stack.Push(20);
        // act
        int result = stack.Peek();
        // assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void CustomStack_PopReturnsTheLastValue()
    {
        // arrange
        CustomStack<string> stack = new CustomStack<string>();
        stack.Push("Some");
        stack.Push("Body");
        stack.Push("Once");
        stack.Push("Told");
        stack.Push("Me");
        // act
        string result = stack.Pop();
        // assert
        Assert.Equal("Me", result);
    }
    
    [Fact]
    public void CustomStack_ThrowsErrorWhenStackIsFull()
    {
        // arrange
        CustomStack<string> stack = new CustomStack<string>();
        for (int i = 0; i < 10; i++)
        {
            stack.Push("Hello");
        }
        Assert.Throws<IndexOutOfRangeException>(() => stack.Push("Goodbye"));
    }

    [Fact]
    public void CustomStack_PopOnEmptyStack()
    {
        // arrange
        CustomStack<string> stack = new CustomStack<string>();
        // assert
        Assert.Throws<IndexOutOfRangeException>(() => stack.Pop());
    }
}