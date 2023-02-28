/* Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины. */



//string[] str_num = Console.ReadLine()!.Split(' ', ',', '.');

int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();

// for (int i = 0; i < 3; i++)

//    array[i] = int.Parse(str_num[i]);

if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[0] + (array[2]) > array[1])

    Console.Write($"Треугольник существует ");

else

    Console.Write($"Треугольника не существует ");












