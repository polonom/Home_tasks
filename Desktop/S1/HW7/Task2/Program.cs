// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
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
Console.WriteLine("Введите число, которое хотите найти");
int numb = Convert.ToInt32(Console.ReadLine());
int[] FindIndexOfNumber(int[,] array, int number)
{
    int[] arr = new int[] { 10, 10 };
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i, j] == number)
            {
                arr[0] = i;
                arr[1] = j;
            }

        }

    }
    return arr;

}
int[,] arr2d = MakeRandom2DArray();
PrintArray2D(arr2d);
int[] res = FindIndexOfNumber(arr2d, numb);
if (res[0] == 10 || res[1] == 10)
{
    Console.WriteLine("Нет такого числа");
}
else
{
    Console.WriteLine($"координаты числа - ({res[0]},{res[1]})");
}
