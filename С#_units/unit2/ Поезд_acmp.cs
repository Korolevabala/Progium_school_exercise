// Задача взята из сайта acmp.ru(школа программиста)
// Входные данные:
// Первая строка время отбытия поезда
// Вторая количество минут 
// Выходные данные:
// Результат Часы и минуты прибытия

using System;

class Program
{
    static void Main() {
        int hours, minutes;
        int time;

        Console.WriteLine("Введите время отправки часы-");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("минуты-");
        minutes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Время пути в минутах");
        time = Convert.ToInt32(Console.ReadLine());
        minutes = minutes + (time % 60);
        time = time - (time % 60);
        if (minutes >= 60)
        {
            minutes = minutes % 60;
            hours++;
        }
        hours = hours + (time / 60);
        hours = hours % 24;
        Console.WriteLine("Время прибытия: "+ hours + ":" + minutes);
    }
}