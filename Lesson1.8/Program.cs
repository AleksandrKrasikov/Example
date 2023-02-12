/* Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.  
4-> "-4, -3, -2, 0, 1, 2, 3, 4"
2 -> "-2, -1, 0, 1, 2"               */

int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N < 0)
        N *= -1;

    for (int i = 0, j = N; i <= N; i++, j--)
    {
        Console.Write($"{i}{j} ");
    }
}
else
    Console.Write("Неверный ввод"); 