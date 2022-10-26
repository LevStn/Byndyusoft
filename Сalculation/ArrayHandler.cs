using Сalculation.Exceptions;

namespace Сalculation;

public class ArrayHandler
{
    public int? GetSumOfTwoSmallerValues(int[] array)
    {
        CheckArray(array);

        var first = array[array.Length - 1];
        var second = array[array.Length - 2];

        for (int i = 0; i < array.Length - 2; i++)
        {
            if (array[i] < first)
            {
                if(first < second)
                {
                    second = first;
                    first = array[i];
                };
                first = array[i];
                continue;
            }
            if (array[i] < second)
            {
                second = array[i];
            }
        }
        return first + second;
    }

    private void CheckArray(int[] array)
    {
        if (array is null )
        {
            throw new NullReferenceException(ErrorMessage.ArrayEmpty);
        }
        switch (array.Length)
        {
            case 0:
                throw new IndexOutOfRangeException(ErrorMessage.SmallLength);
            case 1:
                throw new IndexOutOfRangeException(ErrorMessage.ArrayEmpty);
        }
    }
}