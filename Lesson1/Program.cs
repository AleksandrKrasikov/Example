// Умножаем число само на себя.


int number;
Console.Write("Введите число: ");
//string text = Console.ReadLine()!;

int.TryParse(Console.ReadLine()!, out number);
//int number = int.Parse(text);

Console.Write($"{number}^2 = {number * number}"); 
/*Console.Write(number);
Console.Write("^2 = ");
Console.Write(number * number);*/