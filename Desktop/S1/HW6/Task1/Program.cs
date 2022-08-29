//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CountNumbersGraterThanZero(int[] array){
    int counter = 0;
    for (int i = 0; i< array.Length; i++){
        if (array[i] > 0){
            counter++;
        }
    }
    return counter;
}

Console.WriteLine("Введите набор чисел");
string input = Console.ReadLine();
int[] GiveMeAnArray(string line){
   int[] arr = line.Split(',').Select(int.Parse).ToArray();
   return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  {array[i]} ");
    }
}
PrintArray(GiveMeAnArray(input));
int[] newarr = GiveMeAnArray(input);
int res = CountNumbersGraterThanZero(newarr);
Console.WriteLine($"Количество положительных чисел в строке - {res}");