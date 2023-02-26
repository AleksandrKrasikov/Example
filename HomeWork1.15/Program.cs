/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = FillArray(4, -100, 100);
int sum = 0;

for (int i = 0; i < array.Length; i+=2)
    sum = sum + array[i];


Console.Write($"[{String.Join(", ", array)}] - > {sum}");



int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}
