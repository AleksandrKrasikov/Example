/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний ит.д.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21       */

int[] array = FillArray(5, 0, 10);
int[] pairs = new int[array.Length /2 + array.Length %2];

Console.Write($"{String.Join("  ", array)}\n");
MultiplyPairs(array, pairs);
Console.Write($"{String.Join(" ", pairs)}\n");

void MultiplyPairs(int[] arr, int[] pair)
{
    int size = arr.Length;
    int pairSize = pair.Length;
    
    for (int i = 0; i < size / 2; i++)
    {
        int rev = size - i - 1;
        pair[i] = arr[i] * arr[rev];        
    }
    if (size % 2 != 0)
        pair[pairSize -1] = arr[pairSize - 1];
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}