Console.WriteLine("Задайте кол-во строк 1-ой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбцов 1-ой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows1, columns1];
int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max,int[,] matrix1)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix1;
}
void PrintMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],4}, ");
            else Console.Write($"{matrix1[i, j],4}   ");
        }
        Console.WriteLine("|");
    }
}

void PrintMatrixDouble(double[] matrix1)
{

        for (int j = 0; j < matrix1.GetLength(0); j++)
        {
            Console.Write(matrix1[j]);
            Console.Write(" ");
        }

    Console.Write("\n");
}

double[] MiddleArifmetic(int[,] matrix1)
{
    int size = matrix1.GetLength(1);
    double[] result = new double[size];
    int count = 0;
    for (int j = 0; j < matrix1.GetLength(1); j++) 
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {      
            result[count] +=matrix1[i, j];
            
            
        }
        result[count] =result[count] / matrix1.GetLength(0);
        count++;
            
    }
    
    return result;
}
int[,] n = CreateMatrixRndInt1(rows1, columns1,0,100,matrix);
double [] s = MiddleArifmetic(matrix);
Console.Write("Среднее арифметическое каждого столбца:");PrintMatrixDouble(s);
PrintMatrix(n);