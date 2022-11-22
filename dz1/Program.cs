Console.WriteLine("Ведите трёхзначное число:");
int three_digit_number = Convert.ToInt32(Console.ReadLine());
int num1(int num2)
{
    num2 = num2 / 10;
    return  num2 % 10 ;
}
int result = num1(three_digit_number);
Console.WriteLine($"Вторая цифра:");
Console.WriteLine(result);