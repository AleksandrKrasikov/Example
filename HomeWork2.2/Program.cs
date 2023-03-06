/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int number;
Console.Write("Введите номер дня недели  "); 
int.TryParse(Console.ReadLine()!,out number); 

if (number < 1 || number > 7)
    Console.Write("Нет такого дня недели");

if (number >= 1 && number <= 5) 
{ 
    Console.Write("Рабочий"); 
} 
else if (number >= 6 && number <= 7) 
{ 
    Console.Write("Выходной"); 
} 

