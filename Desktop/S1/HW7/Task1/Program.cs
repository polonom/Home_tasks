// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Задайте высоту массива");
bool isNumberM = int.TryParse(Console.ReadLine(),out int m);
Console.WriteLine("Задайте ширину массива");
bool isNumberN = int.TryParse(Console.ReadLine(),out int n);
if (isNumberM == false || isNumberN == false){
    Console.WriteLine("Введены не правельные данные");
    return;
}
double[,] res = MakeRandom2DArray(m,n);
PrintArray2D(res);

double[,] MakeRandom2DArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.NextDouble()*10;
        }

    }
    return array;

}
void PrintArray2D(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,6:F1}",array[i, j]);
        }
        Console.WriteLine();

    }
}