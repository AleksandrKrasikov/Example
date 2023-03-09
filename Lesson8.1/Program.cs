/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программадолжна вывести сообщение пользователя.
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

1 5 8 5
4 9 4 2 
7 2 2 6
2 3 4 7 */

int[,] array = new int[4,5];

// int[,] array2 = new int[4,4];

if (array.GetLength(0) != array.GetLength(1))
{
    Console.Write($"Помменять строки и столбцы невозможно.");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = i + 1; j < array.GetLength(1); j++)
    {
        (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
    }
}

/* for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array2[i, j] = array[j, i];
    }
}  */

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}


/*int[] array = new int[5];

Array.Sort(array, (x, y) => x.CompareTo(y)); */ // Сортировка массива по возрастанию.

/* List<int> array = new List<int>();

for (int i = 0; i < 5; i++)
    array.Add(new Random().Next(10));
foreach (int item in array)
    Console.Write($"{item} ");

array.Sort((x, y) => y.CompareTo(x)); // Сортировка в обратном порядке
array.Sort();                         // Сортировка от меньшего к большему
Console.WriteLine();
foreach (int item in array)
    Console.Write($"{item} "); */





/* int[] array = new int[5];
foreach (int el in array)
    Console.Write($"{el} ");

AddElement(ref array, 3, 4, 5, 6, 7);

Console.WriteLine();
foreach (int el in array)
    Console.Write($"{el} ");

void AddElement(ref int[] arr, params int [] elements)
{
    int[] t_arr = new int[arr.Length + elements.Length];
    for (int i = 0; i < arr.Length; i++)
        t_arr[i] = arr[i];
    for (int i = 0; i < elements.Length; i++)
        t_arr[i + arr.Length] = elements[i];
    arr = t_arr;
} */



/* List<int> array = new List<int>();
array.Add(5);
array.Insert(0, 3);
array.Insert(1, 8);
array.Add(10);
int[] array2 = new int[] {1, 2, 3, 4, 5};
array.AddRange(array2);*/

//bool flag = array.Remove(5); //Удаляем первую "5"
//int flag = array.RemoveAll(i => i == 5);  //Удаляем все "5" 

//array.RemoveAt(0);


/* bool Remove(int item);
{
    for (int i = 0; i < length; i++)
    {
        if (array[i] == item)
            delete;
            return true;
        
    } 
}  */

/*foreach (int item in array)
    Console.Write($"{item} "); */
/* if (flag)
    Console.Write($"\nУдалили элементов");
else
    Console.Write($"\nНе удалили"); */ 

/*if (flag > 0)
    Console.Write($"\nУдалили {flag} элементов");
else
    Console.Write($"\nНе удалили");*/    

/* int [,] array = new int[4, 4];

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
}      */