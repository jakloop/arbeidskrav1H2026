namespace arbeidskrav1H2026.searchalgorithms;

public class QuickSorter
{
    public static int Comparisons { get; private set; }
    public static int Swaps { get; private set; }
    
    
    // Puts comparisons and swaps to zero
    public static void ResetComparisonsAndSwapsCount()
    {
        Comparisons = 0;
        Swaps = 0;
    }
    
    // QuickSort recursive function
    public static void QuickSort(int[] arr, int low, int high)
    {
        // when it is not possible to divide the array any further we will return 1 or zero
        if (low >= high)
        {
            return;
        }
        // first it finds the pivot
        int pivot = Partition(arr, low, high);
        QuickSort(arr, low, pivot - 1);
        QuickSort(arr, pivot + 1, high);
    }

    // Partition function
    // finds pivot for the quicksort function
    // finds the correct position for the pivot
    private static int Partition(int[] arr, int low, int high)
    {
        // pivot is the highest index value in the array
        int pivot = arr[high];
        
        // this is the boundary of the values we have found that are smaller than the pivot
        int i = low - 1;
        
        // Searches through the array (all but the pivot at the end)
        for (int j = low; j <= high - 1; j++)
        {
            // each time an index in j is compared to the pivot
            Comparisons++;
            
            // when j "finds" a value smaller than the pivot
            // it puts it to the "left" (incremented by 1 each time).
            // this is where the comparison between the pivot and
            if (arr[j] < pivot)
            {
                i++;
                // temp = temporary holder of value while they swap position
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                Swaps++;
            }
        }
        i++;

        // puts the pivot at the "end" of the lower numbers.
        int temp2 = arr[i];
        arr[i] = arr[high];
        arr[high] = temp2;
        Swaps++;
// location of pivot
    return i;
    }
}
    