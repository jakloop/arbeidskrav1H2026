using arbeidskrav1H2026.searchalgorithms;

namespace arbveidskrav1H2026.Tests;

public class UnitTest1
{
    [Fact]
    public void LinearSearch_FindsExistingValue()
    {
        // arrange
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        // act
        var result = SearchAlgorithms.LinearSearch(array, 7);
        // assert
        Assert.Equal(3, result.index);
    }


    [Fact]
    public void LinearSearch_ReturnsMinusOneWhenValueDoesNotExist()
    {
        // arrange
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        // act
        var result = SearchAlgorithms.LinearSearch(array, 6);
        // assert
        Assert.Equal(-1, result.index);
    }


    [Fact]
    public void LinearSearch_ReturnsMinusOneWhenEmptyArray()
    {
        // arrange
        int[] array = [];
        // act
        var result = SearchAlgorithms.LinearSearch(array, 0);
        // assert
        Assert.Equal(-1, result.index);
    }

    [Fact]
    public void LinearSearch_ReturnsValueWhenArrayContainsOnlyOneElement()
    {
        // arrange
        int[] array = [8];
        // act
        var result = SearchAlgorithms.LinearSearch(array, 8);
        // assert
        Assert.Equal(0, result.index);
    }

    [Fact]
    public void BinarySearch_FindsExistingValue()
    {
        // arrange
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        // act
        var result = SearchAlgorithms.BinarySearch(array, 7);
        // assert
        Assert.Equal(3, result.index);
    }


    [Fact]
    public void BinarySearch_ReturnsMinusOneWhenValueDoesNotExist()
    {
        // arrange
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        // act
        var result = SearchAlgorithms.BinarySearch(array, 6);
        // assert
        Assert.Equal(-1, result.index);
    }

    [Fact]
    public void BinarySearch_ReturnsMinusOneWhenEmptyArray()
    {
        // arrange
        int[] array = [8, 3, 11, 7, 2, 9, 5];
        // act
        var result = SearchAlgorithms.BinarySearch(array, 6);
        // assert
        Assert.Equal(-1, result.index);
    }

    [Fact]
    public void BinarySearch_ReturnsValueWhenArrayContainsOnlyOneElement()
    {
        // arrange
        int[] array = [8];
        // act
        var result = SearchAlgorithms.BinarySearch(array, 8);
        // assert
        Assert.Equal(0, result.index);
    }

    [Fact]
    public void BinarySearch_ReturnsTheLeftMostInstanceWhenDuplicateElements()
    {
        // arrange
        int[] array = [1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 8,];
        // act
        var result = SearchAlgorithms.BinarySearch(array, 2);
        // assert
        Assert.Equal(1, result.index);
    }

}