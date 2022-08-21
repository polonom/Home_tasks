int[] arr = new int[5];
int[] FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}
int FindMax(int[] array){
    int maxnumber = array[0];
     for (int i = 0; i < array.Length; i++)
    {
        if (maxnumber < array[i]){
            maxnumber = array[i];
        }
    }
    return maxnumber;
}
int FindMin(int[] array){
    int minnumber = array[0];
     for (int i = 0; i < array.Length; i++)
    {
        if (minnumber > array[i]){
            minnumber = array[i];
        }
    }
    return minnumber;
}
int[] randArray = FillArray(arr);
PrintArray(randArray);
int MaxN= FindMax(randArray);
int MinN = FindMin(randArray);
Console.WriteLine($"разница между максимальным и минимальным элементов массива - {MaxN-MinN}");