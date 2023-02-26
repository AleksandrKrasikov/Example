/* Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]    */

int[] array = CreateArray();

PrintArray(array);
PrintArray2(array);

int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i< array.Length; i++)
            array[i] = new Random().Next(0, 100);
    return array;
}
void PrintArray(int [] array)
{
    for (int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write($" -> ");
}
void PrintArray2(int [] array)
{
    Console.Write("[");
    for (int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}