Console.Write("Введите первое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number;
int Sum(int num, int num2)
{
  for(int i = 1; i<num2; i++)
{
    int constant = num; 
    result = result * constant;
}  
return result;
}
Console.WriteLine(Sum(number,number2));