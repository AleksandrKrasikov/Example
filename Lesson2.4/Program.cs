/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8  */

int number;

number = new Random().Next(10, 100);

int a = number %10;
int b = number /10;
if (a > b)
    Console.Write($"{number} -> {a}");
else
    Console.Write($"{number} -> {b}");
