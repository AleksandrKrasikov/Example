/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

1 4 7 2
5 9 2 3
8 4 2 4

8 4 2 4
5 9 2 3 
1 4 7 2 */

/* List<List<int>> array = new List<List<int>>();

for (int i = 0; i < array.Count; i++) // строки
{
    array.Add(new List<int>());
    for (int j = 0; j < array[i].Count; j++) // столбцы
    {
        array[i].Add(new Random().Next(10));
        Console.WriteLine($"{array[i][j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int lastRow = array.Count - 1;

//for (int i = 0; i < array[0].Count; i++)
//    (array[0][i], array[lastRow][i]) = (array[lastRow][i], array[0][i]);


(array[0], array[lastRow]) = (array[lastRow], array[0]); */


int [,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++) // строки
{
    for (int j = 0; j < array.GetLength(1); j++) // столбцы
    {
        array[i, j] = new Random().Next(10);
        Console.WriteLine($"{array[i, j]} ");
    }
    Console.WriteLine();
}

PrintArray(array);

Console.WriteLine();

int lastRow= array.GetLength(0)-1;

for (int i = 0; i < array.GetLength(1); i++)
{
    (array[0, i], array[lastRow, i]) = (array[lastRow, i], array[0, i]);
}

PrintArray(array);

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