Console.WriteLine("Введите число ");
Console.Write("x:");
int x = Convert.ToInt32(Console.ReadLine());
int cubic(int x1)
{
int count = 1;
while (count <= x1)
    {
        int pow = (int)Math.Pow(count, 3); 
        Console.WriteLine($"{count} | {pow}");
        count = count+1;
    }
    return count;
}
int res = cubic(x);

