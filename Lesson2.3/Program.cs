Print("HelloWorld!!!");
Print("Hello");
Print("Privet");
void Print(string text)
{
    int length = text.Length;
    string border = "--";
    string text2 = "|" + text + "|";
    for (int i = 0; i < length; i++)
        border += "-";
    Console.Write($"{border}\n{text2}\n{border}\n");
}