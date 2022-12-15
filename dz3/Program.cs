Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
int Result(int[] size)
{
    int result = 0;
    for (int i = 0; i < size.Length; i++)
    {
      if (size[i] > 0)
      {
        result++;
      }  
    }
return result;
}
int n = Result(arr);
Console.WriteLine($"Кол-во элементов > 0: {n}");