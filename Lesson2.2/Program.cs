int z = ConsoleTakeIn();

Print(z.ToString());

int ConsoleTakeIn()
{
    int number;
    Console.Write($"Введите число: ");
        bool flag = int.TryParse(Console.ReadLine()!, out number);
    if(flag)
        return number;
    else
        Console.Write($"Введено не число\n");
        return ConsoleTakeIn();
}

void Print(string text)
{
    int length = text.Length;
    string border = "--";
    string text2 = "|" + text + "|";
    for (int i = 0; i < length; i++)
        border += "-";
    Console.Write($"{border}\n{text2}\n{border}\n");
}