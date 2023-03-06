/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int [,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++) // строки
{
    for (int j = 0; j < array.GetLength(1); j++) // столбцы
    {
        array[i, j] = new Random().Next(10);
    }
}
PrintArray(array);


Console.Write("Введите строку: ");
int line;
int.TryParse(Console.ReadLine()!, out line);
line -= 1;
Console.Write("Введите столбец: ");
int colum;
int.TryParse(Console.ReadLine()!, out colum);
colum -= 1;


if (line < 0 | line > array.GetLength(0) - 1 | colum < 0 | colum > array.GetLength(1) - 1)
{
    Console.WriteLine("Такого числа в массиве нет ");
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[line, colum]} ");
}

void PrintArray(Array arr)
{
    switch (arr.Rank)
    {
        case 1:
            for (int i = 0; i < arr.GetLength(0); i++)
                Console.Write($"{arr.GetValue(i)} ");
            break;

        case 2:
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr.GetValue(i, j)} ");
                Console.WriteLine();
            }
            break;
        
        case 3:
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                        Console.Write($"{arr.GetValue(i, j, k)} ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            break;
    }
}


