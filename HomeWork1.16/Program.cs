/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] array = new double [5];
FillArray(array);
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.Write($"[{String.Join("  ", array)}] -> {max - min}");

void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(-100, 100));
        }
}
