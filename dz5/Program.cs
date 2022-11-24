Console.WriteLine("Введите число ");
Console.Write("A:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z= Convert.ToInt32(Console.ReadLine());
Console.Write("B:");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1= Convert.ToInt32(Console.ReadLine());
double range3d(int X, int Y, int Z, int X1,int Y1,int Z1)
{
    return Math.Sqrt((X1-X)*(X1-X) + (Y1-Y) * (Y1-Y) + (Z1-Z) * (Z1-Z));
}
double res = range3d(x,y,z,x1,y1,z1);
double result = Math.Round(res,2);
Console.WriteLine($"A:({x},{y},{z});B:({x1},{y1},{z1}) -> {result}");