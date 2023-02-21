/* Напишите программу, которая принимает на вход число и выдает 
количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5   */




int a = TakeInt();

Console.Write($"{a} -> {Digits(a)}");

int Digits(int _a)
{
    int count = 0;
    while (_a != 0)
    {
        _a /= 10;
        count++;
    }
    return count;
}


int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}
