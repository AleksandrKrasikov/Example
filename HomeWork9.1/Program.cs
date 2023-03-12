/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1   */

int N;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out N);

if (N < 0)
{
    Console.Write("Введено не натуратьное число.");
    return;
}
Console.Write($"N = {N} -> {(PrintNumbers(N))}");

string PrintNumbers(int _n)
{
    if (_n > 1)
        return $"{_n}, {PrintNumbers(_n - 1)}";
    return _n.ToString();
    
}

