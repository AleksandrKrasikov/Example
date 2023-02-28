/* Напишите программу, которая будет преобразовывать десятичное число
в двоичное

45 -> 101101
3 -> 11
2 -> 10        */

int num;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

string num2 = "";

while (num > 0)
{
    num2 = (num % 2).ToString() + num2;
    num /= 2;
}

Console.Write($"{num2}");
