/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write($"{number} -> {number / 10 % 10}");
