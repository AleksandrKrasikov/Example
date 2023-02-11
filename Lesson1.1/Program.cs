/* Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое квадратом второго
a = 25; b = 5 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> да 
a = -3; b = 9 -> нет                   */

int number, number2;
Console.Write("Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write("Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out number2);

if (number == number2 * number2)
{
    Console.Write("Да");
}
if (number != number2 * number2)
{
    Console.Write("Нет");
}