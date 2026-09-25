namespace arbeidskrav1H2026.searchalgorithms;

public class SearchTests
{
    public void Run()
    {
        
        Console.WriteLine("========== Task 1 ==========");
        
        int[] unsortedlist = [8, 3, 11, 7, 2, 9, 5];
        int[] sortedlist = [2, 5, 7, 9, 11, 13, 17];
        int[] emptyList = [];
        int[] duplicatesInList = [2, 5, 6, 7, 7, 9, 9, 10, 25, 54, 64, 109];
        int[] oneElementList = [1];
        
        Console.WriteLine("=========== Linear Search ===========");
        
        var linearSearchFound = SearchAlgorithms.LinearSearch(unsortedlist, 7);
        Console.WriteLine("Linear search for 7");
        Console.WriteLine($"Index: {linearSearchFound.index}");
        Console.WriteLine($"Comparisons = {linearSearchFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(3, linearSearchFound.index)}");
        Console.WriteLine("");
        
        
        var linearSearchNotFound = SearchAlgorithms.LinearSearch(unsortedlist, 42);
        Console.WriteLine("Linear search for 42");
        Console.WriteLine($"Index: {linearSearchNotFound.index}");
        Console.WriteLine($"Comparisons = {linearSearchNotFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(-1, linearSearchNotFound.index)}");
        Console.WriteLine("");
        
        Console.WriteLine("=========== Binary Search ===========");
        var binarySearchFound = SearchAlgorithms.BinarySearch(sortedlist, 13);
        Console.WriteLine("Binary search for 13");
        Console.WriteLine($"Index: {binarySearchFound.index}");
        Console.WriteLine($"Comparisons = {binarySearchFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(5, binarySearchFound.index)}");
        Console.WriteLine("");
        
        var binarySearchNotFound = SearchAlgorithms.BinarySearch(sortedlist, 4);
        Console.WriteLine("Binary search for 4");
        Console.WriteLine($"Index: {binarySearchNotFound.index}");
        Console.WriteLine($"Comparisons = {binarySearchNotFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(-1, binarySearchNotFound.index)}");
        Console.WriteLine("");

        var binarySearchUnsortedNotFound = SearchAlgorithms.BinarySearch(unsortedlist, 5);
        Console.WriteLine("Binary search on unsorted list not found");
        Console.WriteLine($"Index: {binarySearchUnsortedNotFound.index}");
        Console.WriteLine($"Comparisons = {binarySearchUnsortedNotFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(-1, binarySearchUnsortedNotFound.index)}");
        Console.WriteLine("");
        
        var binarySearchUnsortedFound = SearchAlgorithms.BinarySearch(unsortedlist, 9);
        Console.WriteLine("Binary search on unsorted list found");
        Console.WriteLine($"Index: {binarySearchUnsortedFound.index}");
        Console.WriteLine($"Comparisons = {binarySearchUnsortedFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(5, binarySearchUnsortedFound.index)}");
        Console.WriteLine("");
        
        var binarySearchEmptyList = SearchAlgorithms.BinarySearch(emptyList, 1);
        Console.WriteLine("Binary search on empty list");
        Console.WriteLine($"Index: {binarySearchEmptyList.index}");
        Console.WriteLine($"Comparisons = {binarySearchEmptyList.comparisons}");
        Console.WriteLine($"{TestCheck.Check(-1, binarySearchEmptyList.index)}");
        Console.WriteLine("");

        var binarySearchDuplicatesFound = SearchAlgorithms.BinarySearch(duplicatesInList, 7);
        Console.WriteLine("Binary search on list with duplicates");
        Console.WriteLine($"Index: {binarySearchDuplicatesFound.index}");
        Console.WriteLine($"Comparisons = {binarySearchDuplicatesFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(3, binarySearchDuplicatesFound.index)}");
        Console.WriteLine("");
        
        var binarySearchOneElementFound = SearchAlgorithms.BinarySearch(oneElementList, 1);
        Console.WriteLine("Binary search on list with one element found");
        Console.WriteLine($"Index: {binarySearchOneElementFound.index}");
        Console.WriteLine($"Comparisons = {binarySearchOneElementFound.comparisons}");
        Console.WriteLine($"{TestCheck.Check(0, binarySearchOneElementFound.index)}");
        Console.WriteLine("");
    }
}