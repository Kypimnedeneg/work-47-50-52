System.Console.WriteLine("Введите 5 значое число");
int number = Convert.ToInt32(Console.ReadLine());
int Palindrom(int n)
{
    int number1 = n/10000;
    int number2 = n / 1000 % 10;
    int number4 = n / 10 % 10;
    int number5 = n%10;
    if(number1 ==  number5 && number2 == number4) 
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
       Console.WriteLine($"{number} -> нет"); 
    }
return n;
}
int res = Palindrom(number);