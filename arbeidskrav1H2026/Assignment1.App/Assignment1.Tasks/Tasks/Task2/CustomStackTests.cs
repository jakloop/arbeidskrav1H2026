namespace arbeidskrav1H2026.searchalgorithms;

public class CustomStackTests
{
    public void Run()
    {
        Console.WriteLine("========== Task 2 CUSTOM STACK ==========");

        Console.WriteLine("Test pop empty stack");
        var emptyStack = new CustomStack<int>();
        try
        {
            emptyStack.Pop();
            Console.WriteLine("Test failed, exception not thrown");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Test passed, exception thrown");
        }
        Console.WriteLine(" ");
        
        
        Console.WriteLine("Test pop on stack with elements");
        var stack2 = new CustomStack<int>();
        stack2.Push(1);
        try
        {
            var result = stack2.Pop();
            if (result == 1)
                Console.WriteLine("Test passed");
            else
                Console.WriteLine("Test failed");
        }
        catch (Exception)
        {
            Console.WriteLine("Test failed, exception trown");
        }
        Console.WriteLine(" ");
        
        
        Console.WriteLine("Test peek on empty list");
        var emptyStack2 = new CustomStack<int>();
        try
        {
            emptyStack2.Peek();
            Console.WriteLine("Test failed, exception not thrown");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Test passed, exception thrown");
        }
        Console.WriteLine(" ");
        
        
        Console.WriteLine("Test push on stack");
        var stack = new CustomStack<int>();

        try
        {
            stack.Push(1);
            Console.WriteLine("Test passed");
        }
        catch (Exception)
        {
            Console.WriteLine("Test failed");
        }
        Console.WriteLine(" ");
        
        
        Console.WriteLine("Test push on full stack");
        var fullStack = new CustomStack<int>();
        for (int i = 0; i < 10; i++)
        {
            fullStack.Push(i);
        }
        
        try
        {
            fullStack.Push(1);
            Console.WriteLine("Test failed, exception not thrown");
        }
        catch (Exception)
        {
            Console.WriteLine("Test passed, exception thrown");
        }
        Console.WriteLine(" ");

    }
}