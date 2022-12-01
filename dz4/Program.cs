int[] Result(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
return array;
}
void PrintV (int[] array)
{
Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1) Console.Write($"{array[i]}, ");

        else Console.Write(array[i]);

    }
Console.Write("]");
}
int Evennumbers(int[] array)
{
    int Even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0  );
        else Even = array[i] + Even;
    }
return Even;
}
int[] massive = Result(4,0,100);
int evennumvers = Evennumbers(massive);
PrintV(massive);
Console.WriteLine($"-> {evennumvers}");
