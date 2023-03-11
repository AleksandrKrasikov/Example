/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка. */


int [,] array = new int[4, 6];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
    }
}
PrintArray(array);

int summLine = summLineElements(array, 0);
int minSummLine = 0;

for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSummLine = summLineElements(array, i);
    if (summLine > tempSummLine)
    {
        summLine = tempSummLine;
        minSummLine = i;
    }
}

Console.WriteLine();

int summLineElements(int[,] array, int i)
{
    int summLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summLine += array[i,j];
    }
    return summLine;
}

Console.Write($"Cтрокa с наименьшей суммой элементов = {summLine} - {minSummLine+1} Строка.");


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

