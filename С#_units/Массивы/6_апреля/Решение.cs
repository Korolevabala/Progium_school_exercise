using System;

class Program
{
    static void Main()
    {
        int[] mass = new int[10] {5,8,-10,-1,0,12,0,-12,100,999999};
        int elmin = 0;
        int elmax = 0;

        foreach (var element in mass)
        {
            if (elmin > element)
            {
                elmin = element;
            }
            if (elmax < element)
            {
                elmax = element;
            }
        }
        Console.WriteLine("Минимальный элемент =" + elmin + " Максимальный элемент =" + elmax);
    }
}