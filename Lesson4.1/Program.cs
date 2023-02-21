/* Напишите программу, которая принимает на вход число (A)
и выдает сумму чисел от 1 до A.
7 -> 28
4 -> 10
8 -> 36   */




int a = TakeInt();

Console.Write($"{a} -> {Sum(a)}");

int Sum(int _a)
{
    int sum = 0;
    for(int i = 0; i <= a; i++)
        sum += i;
    return sum;
}       


int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}
