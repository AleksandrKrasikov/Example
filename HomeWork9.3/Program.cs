/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29   */

int m, n;
Console.Write($"Введите число m: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите число n: ");
int.TryParse(Console.ReadLine(), out n);

if (m < 0 || n < 0)
{
    Console.Write("Неверный ввод.");
    return;
}
Console.Write($"M = {m}; N = {n} -> A(m,n) = {(FuncAckerman(m, n))}");

int FuncAckerman(int _m, int _n)
{
    if (_m == 0)
        return _n + 1;
    else
        if ((_m != 0) && (_n == 0))
            return FuncAckerman(_m - 1, 1);
        else
            return FuncAckerman(_m -1, FuncAckerman(_m, _n -1));
}