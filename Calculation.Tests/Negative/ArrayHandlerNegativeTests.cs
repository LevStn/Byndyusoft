using System.Collections;
using Сalculation;

namespace Calculation.Tests.Negative;

public class ArrayHandlerNegativeTests
{
    private readonly ArrayHandler _sut;

    public ArrayHandlerNegativeTests()
    {
        _sut = new ArrayHandler();
    }
   
    [Fact]
    public void GetSumOfTwoSmallerValues_WhenArrayOnlyOneValue_ShouldThrowException()
    {
        var newArray = new int[] {1};

        Assert.Throws<IndexOutOfRangeException>(() => _sut.GetSumOfTwoSmallerValues(newArray));
    }

    [Fact]
    public void GetSumOfTwoSmallerValues_WhenArrayEmpty_NullRecived()
    {
        var newArray = new int[] { };

        Assert.Throws<IndexOutOfRangeException>(() => _sut.GetSumOfTwoSmallerValues(newArray));
    }

    [Fact]
    public void GetSumOfTwoSmallerValues_WhenArrayIsNull_ShouldThrowNullReferenceException()
    {
        int[] newArray = null;

        Assert.Throws<NullReferenceException>(() => _sut.GetSumOfTwoSmallerValues(newArray));
    }
}
