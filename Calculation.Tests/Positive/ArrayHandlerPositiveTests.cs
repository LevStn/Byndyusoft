using Ñalculation;

namespace Calculation.Tests.Positive;

public class ArrayHandlerPositiveTests
{
    private readonly ArrayHandler _sut;

    public ArrayHandlerPositiveTests()
    {
        _sut = new ArrayHandler();
    }

    [Theory]
    [InlineData(new object[] { new int[] { 1, 2, 3, 4, 5 }, 3 })]
    [InlineData(new object[] { new int[] { 1, 2, 3, 4 }, 3 })]
    [InlineData(new object[] { new int[] { 4, 2, 3, 1 }, 3 })]
    [InlineData(new object[] { new int[] { 4, 1, 3, 2 }, 3 })]
    [InlineData(new object[] { new int[] { -1, 2, 3, 4, 5 }, 1 })]
    [InlineData(new object[] { new int[] { -1, -2, -300, 4, 500 }, -302 })]
    [InlineData(new object[] { new int[] { -1, -2, -300 }, -302 })]
    [InlineData(new object[] { new int[] { 0, 0, 0 }, 0 })]
    [InlineData(new object[] { new int[] { 5, 5, 5, 5 }, 10 })]
    [InlineData(new object[] { new int[] { -100, 100 }, 0 })]
    [InlineData(new object[] { new int[] { -1, -2, 100 }, -3 })]
    [InlineData(new object[] { new int[] { 100, -2, -1 }, -3 })]
    [InlineData(new object[] { new int[] { -2, 100, -1 }, -3 })]
    public void GetSumOfTwoSmallerValues_WhenArrayValid_SummRecived(int[] array, int expected)
    {
        var actual = _sut.GetSumOfTwoSmallerValues(array);

        Assert.Equal(expected, actual);
    }
}