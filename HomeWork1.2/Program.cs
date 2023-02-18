/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22   */

int num1, num2, num3;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out num2);
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out num3);
int max = num1;

if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;
Console.Write($"max = {max}");
