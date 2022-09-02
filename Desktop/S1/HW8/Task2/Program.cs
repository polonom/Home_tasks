﻿Console.WriteLine("Задайте высоту массива");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Задайте ширину массива");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены не правельные данные");
    return;
}
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
void GiveMeSmallestRow(int[,] array){
    int sum = 0;
    int index=0;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        int newsum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newsum = newsum + array[i,j];
            
        }
      if (newsum>sum){
        sum = newsum;
        index = i+1;
      }

    }
    Console.WriteLine($"Сумма элементов - {sum}, номер строки - {index}");

}
int[,] res = MakeRandom2DArray(m,n);
PrintArray2D(res);
GiveMeSmallestRow(res);
