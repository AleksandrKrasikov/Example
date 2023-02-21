/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12    */

int number = TakeInt();
int len = NumberLen(number);

Console.Write($"{number} -> {SumNumbers(number, len)}");

int NumberLen(int _a)
{
    int index = 0;
    while (_a > 0)
    {
        _a /= 10;
        index++;
    }
    return index;
}

int SumNumbers(int _n, int _len)
{
    int sum = 0;
    for (int i = 1; i <= _len; i++)
    {
        sum += _n % 10;
        _n /= 10;
    }
    return sum;
}

int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}