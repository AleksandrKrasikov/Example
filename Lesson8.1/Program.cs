/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

1 4 7 2
5 9 2 3
8 4 2 4

8 4 2 4
5 9 2 3 
1 4 7 2 */




int [,] array = new int[4, 4];

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



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = i + 1; j < array.GetLength(1); j++)
        {
        (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
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


/* Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза   */