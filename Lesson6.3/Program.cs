/* Не используя рекурсию, выведите первые N чисел Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8 */

int num;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);
ulong left = 0;
ulong right = 1;

while(num > 0)
{
    Console.Write($"{left} ");
    right = left + right;
    left = right - left;
    
    num--;
}



/*Console.Write(FibbRec(num));


string FibbRec(int N, ulong left = 0, ulong right = 1)
{
    if(N <= 1)
        return left.ToString();
    return $"{left.ToString()} {FibbRec(N - 1, right, right + left)}";
} */