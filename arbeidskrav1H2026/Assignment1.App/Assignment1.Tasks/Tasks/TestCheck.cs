namespace arbeidskrav1H2026.searchalgorithms;

using System.Linq;

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

    // AI help - see AI documentation
    public static string ListCheck(int[] list1, int[] list2)
    {
        if (list1.SequenceEqual(list2))
        {
            return "Test passed";
        }
        else
        {
            return "Test failed";
        }
    }
}