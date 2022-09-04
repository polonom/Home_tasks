Console.WriteLine("Задайте высоту массива");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Задайте ширину массива");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены не правельные данные");
    return;
}
int[,] res = MakeRandom2DArray(m, n);
PrintArray2D(res);
Console.WriteLine();
int[,] change = ReputNumbersInArray(res);
PrintArray2D(change);

int[,] MakeRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 11);
        }

    }
    return array;

}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();

    }
}
int[,] ReputNumbersInArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int p = 0; p < array.GetLength(1) - 1; p++)
            {
                if (array[i, p] < array[i, p + 1])
                {
                    int c = array[i, p+1];
                    array[i, p + 1] = array[i, p];
                    array[i, p] = c;
                }

            }

        }

    }
return array;
}