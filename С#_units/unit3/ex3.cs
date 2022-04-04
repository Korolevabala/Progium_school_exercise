using System;

class Program
{
    public static void Main()
    {
        int m = Max_params(1, 2, 10, 54, 67);
        Console.WriteLine(m);
    }
    public static int Max(int first, int second)
    {
        if (first > second) {return (first);}
        return (second);
    }
    public static int Max_params(params int[] numbers)
    {
        int max;
        max = 0; // условно есть минимальное значение для int
        foreach (int n in numbers)
        {
            if (max < n)
            {
                max = n;
            }
        }
        return (max);
    }
}