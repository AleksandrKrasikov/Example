/* Напишите программу, которая перевернет одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]  */

int[] array = FillArray(10);

Console.Write($"[{String.Join(" ", array)}] ->\n");

for (int i = 0; i < array.Length / 2; i++)
{
    int rev = array.Length - i - 1;
    (array[i], array[rev]) = (array[rev], array[i]); 
}

Console.Write($"[{String.Join(" ", array)}]\n");

int[] FillArray(int size, int min = 0, int max = 9)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
            arr[i] = new Random().Next(min, max + 1);
    return arr;
    
} 



