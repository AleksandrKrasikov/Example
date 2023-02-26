/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
Найдите сумму отрицательных и положительных элементов массива.
Например в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
Сумма положительных равна 29; Сумма отрицательных равна -20. */

int[] array = FillArray(12, -9, 10);

Console.Write($"{String.Join(", ", array)}\n");

/* Print(array); */

int pos = 0;
int neg = 0;

foreach(int el in array)
{
    int temp = el > 0 ? pos += el : neg += el;
}

/* for (int i =0; i < array.Length; i++)
{
    if (((byte)array[i] ) 0)
        pos += array[i];
    else
    {
        neg += array[i];
    }
}   */

Console.Write($"pos sum = {pos}\nneg sum = {neg}");

/* void Print(Array arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr.GetValue(i)} ");
    Console.WriteLine();
}   */

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}