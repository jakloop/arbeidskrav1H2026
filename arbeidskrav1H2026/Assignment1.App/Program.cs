
using arbeidskrav1H2026.searchalgorithms;

namespace application;

class Program
{
    static void Main(string[] args)
    {
        //adding some arrays
        int[] SortedArray = [2, 5, 7, 11, 13, 17];
        int[] UnsortedArray = [8, 3, 11, 7, 2, 9, 5];
        int test1 = SearchAlgorithms.BinarySearch(SortedArray, 13);
        int test2 = SearchAlgorithms.BinarySearch(SortedArray, 4);
        int test3 = SearchAlgorithms.LinearSearch(UnsortedArray, 7);
        int test4 = SearchAlgorithms.LinearSearch(UnsortedArray, 42);
        Console.WriteLine($"B-search index: {test1}");
        Console.WriteLine($"B-search index: {test2}");
        Console.WriteLine($"L-search index: {test3}");
        Console.WriteLine($"L-search index: {test4}");
    }
}

