int a = 0;
int b = 0;
Console.Write(Text("Hello this is summ programm"));

a = TakeInt();
b = TakeInt("Введите второе число: ");


/*Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b); */
//int c = a + b;
//Console.Write($"{a} + {b} = {c}"); */

a = Max2(a, b);

Console.Write($"\n{a} {b}\n");

int Max2(int _a, int _b)
{
    int max = _a;
    if (_b > _a)
            return _a;
    return _b;
}

/* int Max3(int _a, int _b, int _c)
{
    return Max2(Max2(_a, _b), _c);
}
int Max4(int _a, int _b, int _c, int _d);
{
    return Max2(Max2(_a, _b), Max2(_c, _d));
}
int Max5(int _a, int _b, int _c, int _d, int _e);
{
    return Max2(Max2(Max2(_a, _b), Max2(_c, _d)), _e);
} */

string Text(string _text)
{
    string border = "--";
    for (int i = 0; i < _text.Length; i++)
        border += "-";
        return $"{border}\n|{_text}|\n{border}\n";
}

int TakeInt(string _str = "Введите число: ")
{
    int _num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}