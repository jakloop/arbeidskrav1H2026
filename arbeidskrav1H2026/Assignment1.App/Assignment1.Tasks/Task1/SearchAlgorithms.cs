namespace arbeidskrav1H2026.searchalgorithms;

public class SearchAlgorithms
{
    // binary search
    public static (int index, int comparisons) BinarySearch(int[] array, int value)
    {
        // The left side starts at index 0
        int left = 0;
        // the right side starts at the end index of the array
        int right = array.Length - 1;
        // Counting amount of operations
        int counter = 0;
        // default result if no value is found
        int result = -1;
        // As long as left is smaller or the same as right we´re still inside the array
        while (left <= right)
        {
            // AI help - (2) AI documentation
            int mid = (left + right) / 2;
            counter++;
            if (array[mid] == value)
            {
                result = mid;
                right = mid - 1;
                
            }
            // if the value is smaller than the value inside the mid index,
            // move right one index down below mid (it's already checked)
            else if (array[mid] > value)
            {
                counter++;
                right = mid - 1; 
            }
            // if the value is greater than the value in the mid index,
            // move left one index above mid (it's already checked)
            else
            {
                counter++;
                left = mid + 1; 
            }
        }
        return (result,  counter);
    }

    // Linear search 
    public static (int index, int comparisons) LinearSearch(int[] array, int value)
    {
        int result = -1;
        int counter = 0;
        
        // for each element in array while I is less than the lenght
        for (int i = 0; i < array.Length; i++) 
        {
            counter++;
            if (value == array[i])
            {
                result = i;
                break;
            }
        }
        return (result, counter);
    }
}