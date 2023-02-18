/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98  */

int number;

number = new Random().Next(100, 1000);

int a = number % 10;
int b = number / 100;

// int number2 = b * 10 + a;

string number2 = b.ToString() + a.ToString();
//string number2 = number.ToString();
Console.Write($"{number} -> {number2}");
//Console.Write($"{number} -> {number2[0]}{number2[2]}");
