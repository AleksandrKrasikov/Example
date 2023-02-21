/* Напишите программу, которая принимает на вход число N и выдает 
произведение чисел от 1 до N.
4 -> 24
5 -> 120   */




int a = TakeInt();

Console.Write($"{a} -> {Digits(a)}");

int Digits(int _a)
{
    int result = 1;
    for (int i = 2; i <= _a; i++)
        result *= i;
        return result; 
}


int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}
