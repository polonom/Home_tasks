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

int[,,] MakeArray(int[,,] array)
{
  int[] con = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number=0;
  for (int i = 0; i < con.GetLength(0); i++)
  {
    con[i] = new Random().Next(10, 100);
    number = con[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (con[i] == con[j])
        {
          con[i] = new Random().Next(10, 100);
          j = 0;
          number = con[i];
        }
          number = con[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = con[count];
        count++;
      }
    }
  }
  return array;
}
int[,,] array = new int[m,n,f];
int[,,] res = MakeArray(array);
PrintArray(res);
