using arbeidskrav1H2026.searchalgorithms;

namespace arveidskrav1H2026.Tests;

public class UnitTest1
{
    [Fact]
    public void LinearSearch_FindsExistingValue()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];

        int result = SearchAlgorithms.LinearSearch(array, 7);

        Assert.Equal(3, result);
    }

    [Fact]
    public void LinearSearch_ReturnsMinusOneWhenValueDoesNotExist()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        int result = SearchAlgorithms.LinearSearch(array, 6);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void LinearSearch_ReturnsMinusOneWhenEmptyArray()
    {
        int[] array = [];
        int result = SearchAlgorithms.LinearSearch(array, 0);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void LinearSearch_ReturnsValueWhenArrayContainsOnlyOneElement()
    {
        int[] array = [8];
        int result = SearchAlgorithms.LinearSearch(array, 8);
        Assert.Equal(0, result);
    }

    [Fact]
    public void BinarySearch_FindsExistingValue()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        int result = SearchAlgorithms.BinarySearch(array, 7);
        Assert.Equal(3, result);
    }
}