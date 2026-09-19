namespace arbeidskrav1H2026.searchalgorithms;

public class QuickSorter
{
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

    private static int Partition(int[] arr, int low, int high)
    {
        // pivot is the highest indexvalue in the array
        int pivot = arr[high];
        
        // this is the boundary of the values we have found that are smaller than the pivot
        int i = low - 1;
        
        // Searches through the array (all but the pivot at the end)
        for (int j = low; j <= high - 1; j++)
        {
            // when j "finds" a value smaller than the pivot
            // it puts it to the "left" (incremented by 1 each time).
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        i++;
        // temporary holder of value
        // puts the pivot at the "end" of the lower numbers.
        int temp2 = arr[i];
        arr[i] = arr[high];
        arr[high] = temp2;
// location of pivot
    return i;
    }
}
    