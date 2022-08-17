// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] mas = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
string s = string.Join(",", mas);
Console.Write($"[{s}]");
