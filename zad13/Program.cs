// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Введите любое целое число");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0, p = 0;
if (num > 99)
{
    p = num;
    while (p >= 1000)
    {
        p/=10;
        d = p % 10;
    }

    System.Console.WriteLine($"Третья цифра слева {d}");
}
else
{
    System.Console.WriteLine($"Третьей цифры нет");
}
