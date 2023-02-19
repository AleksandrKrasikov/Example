/* Напишите программу, которая принимает на вход координаты точки (X м Y),
пирчем X ≠ и Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка. */

int x, y;
Console.Write($"Введите x: ");
int.TryParse(Console.ReadLine()!, out x);

Console.Write($"Введите y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0)
{
    if (y > 0)
        Console.Write($"Плоскость 1");
    else
        Console.Write($"Плоскость 4");
}
else
{
    if (y > 0)
        Console.Write($"Плоскость 2");  
    else
        Console.Write($"Плоскость 3");
}


