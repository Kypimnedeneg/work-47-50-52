int[] array = new int[8];
void Result(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,33);
    }
}
Result(array);
void PrintV (int[] arr)
{
Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1) Console.Write($"{array[i]}, ");

        else Console.Write(array[i]);

    }
Console.Write("]");
}
PrintV(array);