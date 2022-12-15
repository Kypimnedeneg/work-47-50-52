Console.WriteLine("Позиция№1 ");
int firstmatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Позиция№2 ");
int doublematrix = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixRndInt1(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(10, 100 + 1);   
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("|");
    }
}
int[,] CreateMatrixRndInt2(int rows, int columns, int first, int doublee)
{ 
  int[,] matrix = new int[rows, columns];
  if (rows >= first) if (columns >= doublee) Console.WriteLine($"{first},{doublee} -> Есть");
  else Console.WriteLine($"{first},{doublee} -> Такого элемента в масиве нет"); 
   else Console.WriteLine($"{first},{doublee} -> Такого элемента в масиве нет");
  return matrix;
}
int[,] n = CreateMatrixRndInt1(3,4);
int[,] s = CreateMatrixRndInt2(3,4,firstmatrix,doublematrix);
PrintMatrix(n);