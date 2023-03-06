/* Задайте двумерный массив размером m X n, заполненный случайными целыми числами.
m = 3; n = 4;

1 4 8 19
5 -2 33 -2
77 3 8 1  */


int [,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++) // строки
{
    for (int j = 0; j < array.GetLength(1); j++) // столбцы
    {
        array[i, j] = new Random().Next(10);
    }
}

PrintArray(array);

/*Array FillArray(params int[] sizes)
{
    int[,] arr = new int[sizes[0], sizes[1]];
    for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                arr.SetValue(new Random().Next(10), i,j);
    return arr;
} */

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