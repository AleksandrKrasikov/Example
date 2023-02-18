/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет  */

int num1;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out num1);
if (num1 % 2 == 0)
    Console.Write("Да");
else
    Console.Write("Нет");