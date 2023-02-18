int x = 5;
int y = 3;

int z = MaxOutputConsole(x, y) * 5;

Console.Write(z);

int Max(int a, int b)
{
    int max = a;
    if (a > b)
        max = a;
    else
        max = b;
    return max;
}
