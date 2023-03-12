/* Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"   */

int M, N;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out M);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out N);


Console.Write(PrintNumbers(M, N));

string PrintNumbers(int M, int N)
{
    if (M >= N)
        return M.ToString();
    return $"{M}, {PrintNumbers(M + 1, N)}";
}