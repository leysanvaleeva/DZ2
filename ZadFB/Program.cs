// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100.
//  При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
//  Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

System.Console.WriteLine("Введите число от 1 до 100");
int num = Convert.ToInt32(Console.ReadLine());
if (num%3==0) System.Console.WriteLine("Fizz");
if (num%5==0) System.Console.WriteLine("Buzz");
if (num%15==0) System.Console.WriteLine("FizzBuzz");
else System.Console.WriteLine($"{num}");
