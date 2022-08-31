int[,] MakeRandom2DArray()
{
    int[,] array = new int[3, 4];
    Random random = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = random.Next(10, 100);
        }

    }
    return array;

}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();

    }
}
double[] FindMeanOfRow(int[,] array)
{
    double g = 0;
    double f = 0;
    double k = 0;
    double l = 0;
    for (int i = 0; i < 3; i++)
    {
        g += array[i, 0];
        f += array[i, 1];
        k += array[i, 2];
        l += array[i, 3];
    }
    double newg = g / 3;
    double newf = f / 3;
    double newk = k / 3;
    double newl = l / 3;

    double[] arr = new double[] { newg, newf, newk, newl };
    return arr;
}
int[,] arRay = MakeRandom2DArray();
PrintArray2D(arRay);
double[] res = FindMeanOfRow(arRay);
void PrintArray(double[] array)
{
    for (int i = 0; i < 4; i++)
    {
        Console.Write("{0,6:F1}", (float)array[i]);
    }
}
PrintArray(res);