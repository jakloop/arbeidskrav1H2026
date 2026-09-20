namespace arbeidskrav1H2026.searchalgorithms;

// Custom stack
public class CustomStack<T>
{
    private T[] items;
    private int count;

    public CustomStack()
    {
        // array size
        items = new T[10];
        count = 0;
    }
    
    // puts value into the index instructed by the count
    public void Push(T item)
    {
        if (count == items.Length)
        {
            throw new IndexOutOfRangeException("Stack is full!");
        }
        items[count] = item;
        count++;
    }
    
    // returns the last item added to the stack
    public T Pop()
    {
        if (count == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty!");
        }
        count--;
        return items[count];
    }
    
    // Looks at the last inserted item in the stack
    public T Peek()
    {
        if (count == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty!");
        }
        {
            return items[count - 1];
        }
    }
    public int Count()
    {
        return count;
    }
}