Console.WriteLine("Задайте первое число");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Задайте второе число");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Задайте третье число");
bool isNumberF = int.TryParse(Console.ReadLine(), out int f);

if (isNumberM == false || isNumberN == false || isNumberF==false)
{
    Console.WriteLine("Введены не правельные данные");
    return;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}





int[,,] array = new int[m,n,f];
