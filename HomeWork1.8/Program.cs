/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да    */

int num;
int r;
int tmp;
int sum = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);
for (tmp = num; num != 0; num = num /10)
{
    r = num % 10;
    sum = sum * 10 + r;
}
if(tmp==sum)
    Console.Write($"{tmp} - Да, это палиндром.");
else
    Console.Write($"{tmp} - Нет, это не палиндром.");