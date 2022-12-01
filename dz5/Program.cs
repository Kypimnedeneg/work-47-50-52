double[] CrateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max- min)+ min; 
        array[i] = Math.Round(num,1);
    }
return array;
}

void  PrintV (double[] array)
{
Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1) Console.Write($"{array[i]}, ");

        else Console.Write(array[i]);

    }
Console.Write("]");
}

double SumArrayMaxMin(double[] array)
{
    double indmax = array[0];
    double indmin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > indmax) indmax = array[i];
        if (array[i] < indmin) indmin = array[i];
    }
    double differenceMaxMin = indmax - indmin;
    return differenceMaxMin;
}

double[] evennumvers = CrateArrayRndDouble(4,10,-10);
PrintV(evennumvers);
double otvet = SumArrayMaxMin(evennumvers);
otvet = Math.Round(otvet,1);
Console.Write($"-> {otvet}");