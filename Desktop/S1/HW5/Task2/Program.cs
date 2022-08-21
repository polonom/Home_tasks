int[] arr= new int[4];
int[] FillArray(int[] array){
    Random random = new Random();
    for (int i=0 ; i<array.Length; i++){
        array[i] = random.Next(1,100);
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
int FindSummOfIndex(int[] array){
    int summ=0;
    for (int i = 1; i<array.Length; i=i+2){
        summ=summ+array[i];
    }
    return summ;
}
int[] randArray = FillArray(arr);
PrintArray(randArray);
int res = FindSummOfIndex(randArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {res}");