using arbeidskrav1H2026.searchalgorithms;

namespace arveidskrav1H2026.Tests;

public class UnitTest1
{
    [Fact]
    public void LinearSearch_FindsExistingValue()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];

        var result = SearchAlgorithms.LinearSearch(array, 7);

        Assert.Equal(3, result.index);
    }


    [Fact]
    public void LinearSearch_ReturnsMinusOneWhenValueDoesNotExist()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        var result = SearchAlgorithms.LinearSearch(array, 6);
        Assert.Equal(-1, result.index);
    }


    [Fact]
    public void LinearSearch_ReturnsMinusOneWhenEmptyArray()
    {
        int[] array = [];
        var result = SearchAlgorithms.LinearSearch(array, 0);
        Assert.Equal(-1, result.index);
    }

    [Fact]
    public void LinearSearch_ReturnsValueWhenArrayContainsOnlyOneElement()
    {
        int[] array = [8];
        var result = SearchAlgorithms.LinearSearch(array, 8);
        Assert.Equal(0, result.index);
    }

    [Fact]
    public void BinarySearch_FindsExistingValue()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        var result = SearchAlgorithms.BinarySearch(array, 7);
        Assert.Equal(3, result.index);
    }


    [Fact]
    public void BinarySearch_ReturnsMinusOneWhenValueDoesNotExist()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        var result = SearchAlgorithms.BinarySearch(array, 6);
        Assert.Equal(-1, result.index);
    }

    [Fact]
    public void BinarySearch_ReturnsMinusOneWhenEmptyArray()
    {
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        var result = SearchAlgorithms.BinarySearch(array, 6);
        Assert.Equal(-1, result.index);
    }

    [Fact]
    public void BinarySearch_ReturnsValueWhenArrayContainsOnlyOneElement()
    {
        int[] array = [8];
        var result = SearchAlgorithms.BinarySearch(array, 8);
        Assert.Equal(0, result.index);
    }

    [Fact]
    public void BinarySearch_ReturnsTheLeftMostInstanceWhenDuplicateElements()
    {
        int[] array = [1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 8,];
        var result = SearchAlgorithms.BinarySearch(array, 2);
        Assert.Equal(1, result.index);
    }

}