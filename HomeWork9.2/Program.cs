/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30    */

int M, N;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out M);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out N);

Console.Write($"M = {M}; N = {N} -> {(SummNumbers(M, N))}");

int SummNumbers(int _m, int _n)
{
    if (_m == 0)
        return (_n * (_n + 1)) / 2;
    else if (_n == 0)
        return (_m * (_m + 1)) / 2;
    else if (_m == _n)
        return _m;
    else if (_m < _n)
        return _n + SummNumbers(_m, _n - 1);
    else
        return _n + SummNumbers(_m, _n + 1);
}

