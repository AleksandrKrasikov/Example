/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* int[,] firstMartrix = new int[2, 2];
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[2, 2];
FillArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[2,2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i,k] * secomdMartrix[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
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

int[,] a = new int[3, 4];
int[,] b = new int[4, 5];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().Next(10);
    }
}
for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = new Random().Next(10);
    }
}


if (a.GetLength(1) != b.GetLength(0))
{
    Console.Write($"Матрицы нельзя умножить.");
    return;
}
int[,] c = new int[a.GetLength(0), b.GetLength(1)];

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(1); k++)
        {
            c[i, j] += a[i, k] * b[k, j];
        }
    }
}

PrintArray(a);
Console.WriteLine();
PrintArray(b);
Console.WriteLine();
PrintArray(c);