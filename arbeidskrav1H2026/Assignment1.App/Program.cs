
using arbeidkrav1H2026.searchalgorithms;

namespace application;

class Program
{
    static void Main(string[] args)
    {
        //adding some arrays
        int[] SortedArray = [1, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 5, 6, 7, 10, 11, 11, 11, 11];
        int[] UnsortedArray = [4, 2, 3, 4, 5, 2];
        int test1 = SearchAlgorithms.BinarySearch(SortedArray, 4);
        int test2 = SearchAlgorithms.LinearSearch(UnsortedArray, 4);
        Console.WriteLine($"Found at index: {test1}");
        Console.WriteLine($"Found at index: {test2}");

        
    }
}

