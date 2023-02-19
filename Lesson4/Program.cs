/* int a = 0;
int b = 0;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);

//int c = a + b;
//Console.Write($"{a} + {b} = {c}");

//a = Max(a, b);


Console.Write($"\n{a} {b}");

int Max2(int _a, int _b)
{
    int max = _a;
    if (_b > _a)
            return _a;
    return _b;
}

int Max3(int _a, int _b, int _c)
{
    return Max3(Max(Max2(_a, _b), _c));
} */
