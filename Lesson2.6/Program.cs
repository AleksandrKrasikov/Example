
/* Напишите программу, которая будет принимать на вход два числа и 
выводить, является ли второе число кратным первому. Если второе 
число не кратно первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно  */

int num1, num2;
Console.Write($"Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out num2);

if (num1 % num2 == 0)
    Console.Write($"Кратно");
else
    Console.Write($"Не кратно, остаток - {num1 % num2}");    