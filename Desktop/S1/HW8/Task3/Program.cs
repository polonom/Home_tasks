int[,] MakeRandom2DArray()
{
    int[,] array = new int[2, 2];
    Random random = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            array[i, j] = random.Next(1, 11);
        }

    }
    return array;

}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();

    }
}
int[,] FindProizvedenieOfMatrix(int[,] arr1,int[,] arr2){
    int[,] newarr= new int[2,2];
     for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int p=0;p<2;p++){
                newarr[i,j]=arr1[i,p]*arr2[p,j];
            }
        }

    }
return newarr;
}
int[,] first = MakeRandom2DArray();
int[,] second = MakeRandom2DArray();
int[,] res = FindProizvedenieOfMatrix(first,second);
PrintArray2D(first);
Console.WriteLine();
PrintArray2D(second);
Console.WriteLine();
PrintArray2D(res);