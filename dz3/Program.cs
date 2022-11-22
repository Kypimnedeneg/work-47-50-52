Console.WriteLine("Введите день недели");
int day_number = int.Parse(Console.ReadLine()!);
bool day(int day_number1)
{
    return day_number1 >= 6 && day_number1 <= 7; 
}
Console.WriteLine(day(day_number) ? "да" : "нет");