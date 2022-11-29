Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfAllnumbers(int num)
{
int result = 0;
    while ( num > 0 )
    {
        int sum1 = num % 10;
        num = num / 10;
        result = result + sum1;
    }
num = result;
return num;
}
int sum22 = sumOfAllnumbers(number);
Console.WriteLine($"Sum = {sum22}");