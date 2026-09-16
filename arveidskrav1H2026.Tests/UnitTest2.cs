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
        CustomStack<string> stack = new CustomStack<string>();
        stack.Push("Some");
        stack.Push("Body");
        stack.Push("Once");
        stack.Push("Told");
        stack.Push("Me");
        
        string result = stack.Pop();
        Assert.Equal("Me", result);
    }
}