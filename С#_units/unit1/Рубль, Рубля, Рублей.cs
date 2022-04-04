// Входные данные:
// Подается любое целое положительное число рублей.
// Выходные данные:
// Результатом должно быть Сумма рублей/рубля/рубль в зависимости от последнего числа суммы

using System

namespace Rub

Class Program
{
    public static int Main()
    {
        int sum;

        Console.WriteLine("Введите сумму");
        sum = Convert.ToInt32(Console.ReadLine());

        //
        Console.WriteLine("У вас: ");
        if (sum  != 11 && sum != 12 && sum != 13 && sum != 14)
        {
            switch (sum % 10)
            {
                case "1":
                    Console.Write(sum + "рубль");
                    break;
                case "2":
                    Console.Write(sum + "рубля");
                    break;
                case "3":
                    Console.Write(sum + "рубля");
                    break;
                case "4":
                    Console.Write(sum + "рубля");
                    break;
                case "5":
                    Console.Write(sum + "рублей");
                    break;
                case "6":
                    Console.Write(sum + "рублей");
                    break;
                case "7":
                    Console.Write(sum + "рублей");
                    break;
                case "8":
                    Console.Write(sum + "рублей");
                    break;
                case "9":
                    Console.Write(sum + "рублей");
                    break;
                case:"0":
                    Console.Write(sum + "рублей");
                    break;
            }
            else
            {
                Console.Write(sum + "рублей");
            }
        }
    }
}