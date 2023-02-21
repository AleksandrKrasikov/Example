/* Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16    */

int A = TakeInt("Введите чило A: ");
int B = TakeInt("Введите чило B: ");

Console.Write ($"{A}, {B} -> {ToDegree(A, B)}");

int ToDegree(int _a, int _b)
{
    int result = 1;
    for (int i = 1; i <= _b; i++)
    {
        result = result * _a;
    }
    return result;
}

int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}