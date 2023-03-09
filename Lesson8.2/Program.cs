/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.

{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза   */



int[,] array = new int[4, 4];
int[] sortarray = new int[array.GetLength(0) * array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        sortarray[i * array.GetLength(1)+j] = array[i, j];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Array.Sort(sortarray, (x, y) => x.CompareTo(y));

int count = 0;
int current = sortarray[0];

for (int i = 0; i < sortarray.Length; i++)
{
    if (sortarray[i] != current || i == sortarray.Length - 1)
    {
        Console.Write($"элемент {current} встречается {count} раз;\n");
        count = 1;
        current = sortarray[i];
    }
    else
        count++;
}
Console.Write($"элемент {current} встречается {count} раз;\n");