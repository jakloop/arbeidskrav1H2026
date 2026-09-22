namespace arbeidskrav1H2026.searchalgorithms;

public class TestCheck
{
    public static string Check(int expectedValue, int actualValue)
    {
        if (expectedValue == actualValue)
        {
            Console.WriteLine($"Expected value: {expectedValue}, result: {actualValue}");
            return "Test passed";
        }
        { 
            Console.WriteLine($"Expected value: {expectedValue}, result: {actualValue}"); 
            return "test failed";
        } 
    }

    public static string CheckExpectedFail(int expectedValue, int actualValue)
    {
        if (expectedValue != actualValue)
        {
            Console.WriteLine($"Expected value: {expectedValue}, result: {actualValue}");
            return "test passed";
        }
         
        Console.WriteLine($"Expected value: {expectedValue}, result: {actualValue}"); 
        return "test failed";
    } 
}