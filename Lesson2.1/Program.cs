//int user;
int x = 5;
int y = 3;

//int.TryParse(Console.ReadLine()!, out user);

int z = MaxOutputConsole(x, y) * 5;

Console.Write(z);

int MaxOutputConsole(int a, int b)
{
    int max = a;
    if (a > b)
        max = a;
    else
        max = b;
    return max;
}
