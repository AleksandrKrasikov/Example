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

    for (int i2 = -N; i2 <= N; i2++)
    {
        Console.Write($"{i2} ");
    }

    /*int i = -N
    while (i <= N)
    {
        Console.Write($"{i} ");
        i += 1 // i++ 
    } */
}
else
    Console.Write("Неверный ввод"); 