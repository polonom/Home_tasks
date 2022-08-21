int[] arr = new int[4];
int[] FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int FindEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter += 1;
        }
    }
    return counter;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

int[] randArray = FillArray(arr);
int res = FindEven(randArray);
PrintArray(randArray);
Console.WriteLine($"Число четных чисел  - {res}");