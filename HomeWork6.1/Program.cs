/* Напишите программу, которая найдёт точку пересечения 
вух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine()!);
if (k1 != k2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"b1= {b1}, k1= {k1}, b1= {b1}, b2= {b2}, k2= {k2} -> ({x}; {y})");
}
else
{
        Console.WriteLine($"b1= {b1}, k1= {k1}, b1= {b1}, b2= {b2}, k2= {k2} -> Не имеет решения.");
}
