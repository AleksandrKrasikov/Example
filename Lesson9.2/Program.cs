/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
Выполнить с помощью рекурсии.

N = 5 -> "1, 2, 3, 4, 5"
N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8   */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out N);

Console.Write(PrintNumbers(N));

string PrintNumbers(int N, int i = 1)
{
    if (i >= N)
        return i.ToString();
    return $"{i}, {PrintNumbers(N, i + 1)}";
}