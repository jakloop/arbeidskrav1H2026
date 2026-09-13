
using arbeidskrav1H2026.searchalgorithms;

namespace application;

class Program
{
    static void Main(string[] args)
    {
        
        // TASK 1 (TEMPORARY OUTLINE
        Console.WriteLine("========== Task 1 ==========");
        Console.WriteLine(" ");
        //adding some arrays
        int[] SortedArray = [2, 5, 7, 11, 13, 17];
        int[] SortedArray2 = [0,0,0,0,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3,3,4,4,4,4,4,4,5,6,7,8,9,9,9,9,9,9];
        int[] UnsortedArray = [8, 3, 11, 7, 2, 9, 5];
        int[] EmptyArray = Array.Empty<int>();
        var btest1 = SearchAlgorithms.BinarySearch(SortedArray, 13);
        var btest2 = SearchAlgorithms.BinarySearch(SortedArray, 4);
        var btest3 = SearchAlgorithms.BinarySearch(EmptyArray, 8);
        var btest4 = SearchAlgorithms.BinarySearch(SortedArray2, 9);
        var ltest1 = SearchAlgorithms.LinearSearch(UnsortedArray, 7);
        var ltest2 = SearchAlgorithms.LinearSearch(UnsortedArray, 42);
        Console.WriteLine($"B-search index: {btest1.index}, Comparison counter = {btest1.comparisons}");
        Console.WriteLine($"B-search index: {btest2.index}, Comparison counter = {btest2.comparisons}");
        Console.WriteLine($"B-search index: {btest3.index}, Comparison counter = {btest3.comparisons}");
        Console.WriteLine($"L-search index: {ltest1.index}, Comparison counter = {ltest1.comparisons}");
        Console.WriteLine($"L-search index: {ltest2.index}, Comparison counter = {ltest2.comparisons}");
        Console.WriteLine($"B-search index: {btest4.index}, Comparison counter = {btest4.comparisons}");
        
        Console.WriteLine(" ");
        Console.WriteLine("========== Task 2 ==========");
        Console.WriteLine(" ");
        
        var norwegianAnimals = new CustomStack<string>();
        norwegianAnimals.Push("Horse");
        norwegianAnimals.Push("Dog");
        norwegianAnimals.Push("Cat");
        norwegianAnimals.Push("Cow");
        norwegianAnimals.Push("Bear");
        norwegianAnimals.Push("Puffin");
        
        Console.WriteLine($"{norwegianAnimals.Pop()}");
        Console.WriteLine($"{norwegianAnimals.LookUpCount()}");
        Console.WriteLine($"{norwegianAnimals.Pop()}");
        Console.WriteLine($"{norwegianAnimals.LookUpCount()}");
        Console.WriteLine($"{norwegianAnimals.Peek()}");
        Console.WriteLine($"{norwegianAnimals.LookUpCount()}");
        
    }
    
}

