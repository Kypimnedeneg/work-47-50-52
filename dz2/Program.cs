Console.WriteLine("Ведите  число:");
int number = Convert.ToInt32(Console.ReadLine());
int first_number(int num1)
{
    while (num1 >= 1000)
    {
        num1 = num1 / 10;
       
    }
return num1 % 10;
}
if (number < 0)
{
    number = Math.Abs(number);
}
if (number> 99)
{
    int result = first_number(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("нет третьей цифры");
}