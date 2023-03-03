using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int number = 0;
        for(int i = 1; i <= max; i++){
            number += i;
        }
        return (int)Math.Pow(number, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int number = 0;
        for(int i = 1; i <= max; i++){
            number += (int)Math.Pow(i,2);
        }
        return number;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return (int)(CalculateSquareOfSum(max) -  CalculateSumOfSquares(max));
    }
}
