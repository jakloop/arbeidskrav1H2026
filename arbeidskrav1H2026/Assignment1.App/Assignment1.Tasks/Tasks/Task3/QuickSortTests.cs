namespace arbeidskrav1H2026.searchalgorithms;

public class QuickSortTests
{
    public void Run()
    {

        Console.WriteLine("========== Task 3: Quick Sort ==========");
        // [64, 34, 25, 12, 22, 11, 90]
        Console.WriteLine("Normal array ");
        int[] array1 = [64, 34, 25, 12, 22, 11, 90];
        int[] array1Test = [11, 12, 22, 25, 34, 64, 90];
        Console.WriteLine("Before: ");
        Console.WriteLine(string.Join(", ", array1));
        QuickSorter.QuickSort(array1, 0, array1.Length - 1);
        Console.WriteLine("After");
        Console.WriteLine(string.Join(", ", array1));
        Console.WriteLine(TestCheck.ListCheck( array1 ,array1Test));
        Console.WriteLine(" ");
        
        
        // et allerede sortert array, for eksempel [1, 2, 3, 4, 5]
        Console.WriteLine("Sorted array ");
        int[] sortedArray = [1, 2, 3, 4, 5];
        int[] sortedArrayTest = [1, 2, 3, 4, 5];
        Console.WriteLine("Before: ");
        Console.WriteLine(string.Join(", ", sortedArray));
        QuickSorter.QuickSort(sortedArray, 0, sortedArray.Length - 1);
        Console.WriteLine("After");
        Console.WriteLine(string.Join(", ", sortedArray));
        Console.WriteLine(TestCheck.ListCheck( sortedArray ,sortedArrayTest));
        Console.WriteLine(" ");
        
        // et omvendt sortert array, for eksempel [9, 8, 7, 6, 5]
        Console.WriteLine("Sorted array ");
        int[] sortedArrayDecreasing = [9, 8, 7, 6, 5];
        int[] sortedArrayDecreasingTest = [5, 6, 7, 8, 9];
        Console.WriteLine("Before: ");
        Console.WriteLine(string.Join(", ", sortedArrayDecreasing ));
        QuickSorter.QuickSort(sortedArrayDecreasing, 0, sortedArrayDecreasing.Length - 1);
        Console.WriteLine("After");
        Console.WriteLine(string.Join(", ", sortedArrayDecreasing));
        Console.WriteLine(TestCheck.ListCheck( sortedArrayDecreasing ,sortedArrayDecreasingTest));
        Console.WriteLine(" ");
        
        

        Console.WriteLine("Array with duplicates ");
        int[] arrayWithDuplicates = [64, 34, 25, 12, 22, 22, 11, 34, 90];
        int[] arrayWithDuplicatesTest = [11, 12, 22, 22, 25, 34, 34, 64, 90];
        Console.WriteLine("Before: ");
        Console.WriteLine(string.Join(", ", arrayWithDuplicates ));
        QuickSorter.QuickSort(arrayWithDuplicates, 0, arrayWithDuplicates.Length - 1);
        Console.WriteLine("After");
        Console.WriteLine(string.Join(", ", arrayWithDuplicates));
        Console.WriteLine(TestCheck.ListCheck( arrayWithDuplicates ,arrayWithDuplicatesTest));
        Console.WriteLine(" ");
        
        // et tomt array og et array med én verdi
        Console.WriteLine("Empty array ");
        int[] emptyArray = [];
        int[] emptyArrayTest = [];
        Console.WriteLine("Before: ");
        Console.WriteLine(string.Join(", ", emptyArray ));
        QuickSorter.QuickSort(emptyArray, 0, emptyArray.Length - 1);
        Console.WriteLine("After");
        Console.WriteLine(string.Join(", ", emptyArray));
        Console.WriteLine(TestCheck.ListCheck( emptyArray ,emptyArrayTest));
        Console.WriteLine(" ");
        
        Console.WriteLine("Array with one element");
        int[] arrayWithOneElement = [1];
        int[] arrayWithOneElementTest = [1];
        Console.WriteLine("Before: ");
        Console.WriteLine(string.Join(", ", arrayWithOneElement ));
        QuickSorter.QuickSort(arrayWithOneElement, 0, arrayWithOneElement.Length - 1);
        Console.WriteLine("After");
        Console.WriteLine(string.Join(", ", arrayWithOneElement));
        Console.WriteLine(TestCheck.ListCheck( arrayWithOneElement, arrayWithOneElementTest));
        Console.WriteLine(" ");
    }
}