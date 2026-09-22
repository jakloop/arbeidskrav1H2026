namespace arbeidskrav1H2026.searchalgorithms;

public class SearchTests
{
    public void Run()
    {
        
        TestCheck Check = new TestCheck();
        Console.WriteLine("========== Task 1 ==========");
        Console.WriteLine("LINEAR Search Algorithms");
        int[] unsortedlist = [8, 3, 11, 7, 2, 9, 5];
        int[] sortedlist = [2, 5, 7, 9, 11, 13, 17];
        int[] emptyList = [];
        
        int target3 = 7;
        int target4 = 42;
        
        var ltest1 = SearchAlgorithms.LinearSearch(unsortedlist, 7);
        var ltest2 = SearchAlgorithms.LinearSearch(unsortedlist, 42);
        Console.WriteLine("Test: Linear search on unsorted list");
        Console.WriteLine($"Linear search: index: {ltest1.index}, Comparison counter = {ltest1.comparisons}");
        Console.WriteLine($"Linear search: index: {ltest2.index}, Comparison counter = {ltest2.comparisons}");
        
        Console.WriteLine("BINARY Search Algorithms");
        int target1 = 13;
        int target2 = 4;
        var btest1 = SearchAlgorithms.BinarySearch(sortedlist, target1);
        var btest2 = SearchAlgorithms.BinarySearch(sortedlist, target2);
        var btest3 = SearchAlgorithms.BinarySearch(emptyList, target3);
        var btest4 = SearchAlgorithms.BinarySearch(unsortedlist, 3);
        var btest5 = SearchAlgorithms.BinarySearch(unsortedlist, target4);

        Console.WriteLine("Test: Binary search on sorted list");
        Console.WriteLine($"Binary search: index: {btest1.index}, Comparison counter = {btest1.comparisons}");
        Console.WriteLine($"Binary search: index: {btest2.index}, Comparison counter = {btest2.comparisons}");
        Console.WriteLine($"BINARY Search: Empty list");
        Console.WriteLine($"Binary search: index: {btest3.index}, Comparison counter = {btest3.comparisons}");
        Console.WriteLine($"BINARY Search: Unsorted list");
        
        
        
    }
}