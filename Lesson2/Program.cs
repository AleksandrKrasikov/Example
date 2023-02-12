int x = 5;
int y = 3;

MaxOutputConsole(x, y);

void MaxOutputConsole(int a, int b)
{
    int max = a;
    if (a > b)
        Console.Write($"max = {a}");
    else
        Console.Write($"max = {b}");
}