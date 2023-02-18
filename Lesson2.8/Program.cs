/* Напишите программу, которая будет принимать на вход два числа и 
проверяет, является ли одно число квадратом другого.  */

int num1, num2;
Console.Write($"Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out num2);

if (num1 == num2 * num2)
    Console.Write($"Да");
else
    Console.Write($"Нет");  
