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
}