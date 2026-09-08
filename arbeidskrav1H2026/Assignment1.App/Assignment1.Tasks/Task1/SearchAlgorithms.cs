namespace arbeidkrav1H2026.searchalgorithms;

public class SearchAlgorithms
{
    // binary search
    public static int BinarySearch(int[] array, int value)
    {
        // The left side starts at index 0
        int left = 0;
        
        // the right side starts at the end index of the array
        int right = array.Length - 1;
        
        // Counting amount of operations
        int counter = 0;
        
        // As long as left is smaller or the same as right we´re still inside the array
        while (left <= right)
        {
            // mid starts in the middle of the array
            int mid = (left + right) / 2;
            if (array[mid] == value)
            {

                    counter++;
                    return mid;
            }
            
            // if the value is smaller than the value inside the mid index,
            // move right one index down below mid (it's already checked)
            if  (array[mid] > value)
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
        // if value is not found, return -1
        return -1;
    }

    // Linear search 
    public static int LinearSearch(int[] array, int value)
    {
        int counter = 0;
        
        // for each element in array while I is less than the lenght
        for (int i = 0; i < array.Length; i++) 
        {
            counter++;
            if (value == array[i])
            {
                return i;
            }
        }
        return -1;
    }
}