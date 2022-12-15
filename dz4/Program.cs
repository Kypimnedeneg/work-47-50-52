Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double Result(double B1, double K1,double B2,double K2)
{
    double x = (-B2 + B1)/(-K1 + K2);
    double y = K2 * x + B2;
    return y;
}
double tohka  =  Result(b1,k1,b2,k2);
Console.WriteLine($"две прямые пересекутся в точке с координатами ({tohka};{tohka})");