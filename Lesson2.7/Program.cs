/* Напишите программу, которая будет принимать на вход число и 
проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да  */

int num1;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num1);

if (num1 % 7 == 0 && num1 % 23 == 0)
    Console.Write($"Да");
else
    Console.Write($"Нет");    