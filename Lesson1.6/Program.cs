
int N;
Console.Write("Введите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N % 2 == 0)
        Console.Write("Число четное");
    else
        Console.Write("Число нечетное");
}
else
    Console.Write("Неверный ввод"); 