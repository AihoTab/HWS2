//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
if (Math.Abs(a) < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (Math.Abs(a) >= 1000)
        a /= 10;
    Console.WriteLine($"Третья цифра: {a % 10}");
}